using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo.Connected
{
    public interface IBrokerRepository //Repository class, needed for dependency inversion. Interfaces used to implement methods
    {
        List<Broker> GetAllBrokers();

        void AddNewBroker(Broker brokerToAdd); //New method to add brokers

        void UpdateBroker(int BrokerToUpdateId, Broker newBroker); //New method to update brokers

        void RemoveBroker(int BrokerToRemoveId); //New method to remove brokers
    }

    public class MicrosoftSqlServerBrokerRepository : IBrokerRepository
    {
        string _connectionString; //Make string
        IDbConnection connection;
        IDbCommand command;

        public MicrosoftSqlServerBrokerRepository(string ConnectionString)  //Use dependency injection to provide string to class by making a constructor
        {
            _connectionString = ConnectionString;
        }

        public List<Broker> GetAllBrokers()
        {
            List<Broker> allBrokers = new List<Broker>();

            string _sqlStatement = "SELECT id, firstName, lastName FROM brokers";  //Need to come up with a query
            
            connection = new SqlConnection(_connectionString);   //Use package manager to run this. We are using interfaces here so these variables are able to hold anything  using any IDb commands. Connection is encapsulating where the database is. 
            command = new SqlCommand(_sqlStatement, (SqlConnection)connection);    //This Command hold everything, so what and where. Cast w (SqlConnection) to rid of error. Its an SQL command, needs a connection before it continues.

            try
            {
                connection.Open();  //Connects to the database
                IDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    allBrokers.Add(new Broker()  //using reader object much like a list/connection. 
                    {
                        id = int.Parse(reader["id"].ToString()),  //Accessing database directly so ensure it matches up to your columns. CONVERT INTO CORRECT TYPES.
                        firstName = reader["firstName"].ToString(),
                        lastName = reader["lastName"].ToString()
                    });
                }

                
            }

            catch (SqlException exception)
            {
                //Log exception .. could very well be used!
                return allBrokers; 
            }

            finally
            {
                connection.Close(); //keeping it open will slow program down. 
            }
            //USED A TRYF ENCAPSULATION around the open close for data persistance.
            return allBrokers;
        }


        public void AddNewBroker(Broker brokerToAdd)
        {
            string _sqlStatement = "INSERT INTO brokers(id, firstName, lastName) VALUES(@id, @firstName, @lastName)";

            connection = new SqlConnection(_connectionString);
            command = new SqlCommand(_sqlStatement, (SqlConnection)connection);

            IDataParameter param = new SqlParameter("@id", SqlDbType.Int, 25); //SET UP A PARAM W PLACEHOLDER ID. REPLACING :ID WITH THE BROKER TO ADD.ID.
            param.Value = brokerToAdd.id;
            command.Parameters.Add(param);

            IDataParameter param1 = new SqlParameter("@firstName", SqlDbType.VarChar, 255); //SET UP A PARAM W PLACEHOLDER FIRST NAME. REPLACING :firstName WITH THE BROKER TO ADD.firstName
            param1.Value = brokerToAdd.firstName;
            command.Parameters.Add(param1);

            IDataParameter param2 = new SqlParameter("@lastName", SqlDbType.VarChar, 255); //SET UP A PARAM W PLACEHOLDER LAST NAME. REPLACING :lastName WITH THE BROKER TO ADD.lastName
            param2.Value = brokerToAdd.lastName;
            command.Parameters.Add(param2);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }


        public void UpdateBroker(int BrokerToUpdateId, Broker newBroker)
        {
            string _sqlStatement = "UPDATE brokers SET firstName = @firstName, lastName = @lastName WHERE id = @id";
                
            connection = new SqlConnection(_connectionString);
            command = new SqlCommand(_sqlStatement, (SqlConnection)connection);

            IDataParameter param = new SqlParameter("@firstName", SqlDbType.VarChar, 255);
            param.Value = newBroker.firstName;
            command.Parameters.Add(param);

            IDataParameter param1 = new SqlParameter("@lastName", SqlDbType.VarChar, 255);
            param1.Value = newBroker.lastName;
            command.Parameters.Add(param1);

            IDataParameter param2 = new SqlParameter("@id", SqlDbType.Int, 55);
            param2.Value = BrokerToUpdateId;
            command.Parameters.Add(param2);

            try 
	        {
                connection.Open();

                command.ExecuteNonQuery();
	        }
	        catch (SqlException ex)
	        {
		
		        throw;
	        }
            finally
            {
                connection.Close();
            }
        }


        public void RemoveBroker(int BrokerToRemoveId)
        {
            string _sqlStatement = "DELETE FROM brokers WHERE id = @id";

            connection = GetConnection();
            command = GetCommand(_sqlStatement);

            IDataParameter param = new SqlParameter("@id", SqlDbType.Int, 55);
            param.Value = BrokerToRemoveId;
            command.Parameters.Add(param);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        private IDbConnection GetConnection()
            {
                return new SqlConnection(_connectionString);
            }

            private IDbCommand GetCommand(string _sqlStatement)
            {
                return new SqlCommand(_sqlStatement, (SqlConnection)connection);
            }
        }
    }

//SET UP A REPOSITORY DESIGN PATTERN. VERY SIMPLE EXAMPLE.