using System;
using System.Data;
using System.Data.SqlClient;


namespace GraphPrinter
{
    class SqlHelper
    {
        #region variables;
        public DataSet DataSetEntete = new DataSet();
        public DataSet DataSetDonnee = new DataSet();
        SqlConnection connexionBanc = new SqlConnection(Properties.Settings.Default.StrConnDonn);
        #endregion;

        /// <summary>
        /// Ouvre la connexion avec la BDD
        /// </summary>
        /// <param name="connexion"></param>
        /// <returns> Boolean pour savoir si la connexion est établie</returns>
        public bool OpenConnexion(SqlConnection connexion)
        {
            try
            {
                connexion.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        /// <summary>
        /// Ferme la connexion avec la BDD
        /// </summary>
        /// <param name="connexion"></param>
        /// <returns>Boolean pour savoir si la connexion est bien fermée</returns>
        public bool CloseConnexion(SqlConnection connexion)
        {
            try
            {
                connexion.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public void UpdateDataSetEntete()
        {
            String query = "Select * from Entête";

            if (this.OpenConnexion(connexionBanc) == true)
            {
                SqlCommand cmd = new SqlCommand(query, connexionBanc);
                SqlDataAdapter adapteur = new SqlDataAdapter(cmd);
                adapteur.Fill(DataSetEntete, "Entête");
                this.CloseConnexion(connexionBanc);
            }
        }

        public void UpdateBDDEntete()
        {
            if(this.OpenConnexion(connexionBanc) == true)
            { 
                SqlDataAdapter adapteur = new SqlDataAdapter();
                adapteur = CreateCustomerAdapter(connexionBanc);

                adapteur.Update(DataSetEntete,"Entête");
                this.CloseConnexion(connexionBanc);
            }
        }

        public static SqlDataAdapter CreateCustomerAdapter(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            // Create the DeleteCommand.
            SqlCommand MyDeleteCommand = new SqlCommand(
           "DELETE FROM Entête WHERE ID=@ID", connection);

            // Add the parameters for the DeleteCommand.
            MyDeleteCommand.Parameters.Add("@ID", SqlDbType.Int, 4, "ID");
            // Assign the SqlCommand to the DeleteCommand
            adapter.DeleteCommand = MyDeleteCommand;

            return adapter;
        }

        public void UpdateDataSetDonnee(int id)
        {
            String query = "Select * From Données Where ID = " + id;
            if (this.OpenConnexion(connexionBanc) == true)
            {
                SqlCommand cmd = new SqlCommand(query, connexionBanc);
                SqlDataAdapter adapteur = new SqlDataAdapter(cmd);
                adapteur.Fill(DataSetDonnee, id.ToString());
                this.CloseConnexion(connexionBanc);
                Boolean start = false;
                while (start == false)
                {
                    float data = new float();
                    data = float.Parse(DataSetDonnee.Tables[id.ToString()].Rows[0]["vitesse"].ToString());
                    if (data < -25 || data>25)
                    {
                        start = true;
                    }
                    DataSetDonnee.Tables[id.ToString()].Rows.RemoveAt(0);
                }
            }
        }

    }
}
