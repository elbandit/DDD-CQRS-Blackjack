using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Security;
using NHibernate.Linq;

namespace KojackGames.Blackjack.Acceptance.Tests.Utilities
{
    public static class DataBaseHelper
    {       
        public static void clear_db()
        {            
            using (var conn = new SqlConnection(String.Format(@"Data Source=.\SQLEXPRESS;AttachDbFilename={0}\App_Data\Blackjack.mdf;Integrated Security=True;User Instance=True", WebSiteFileLocation.get_physical_path())))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "delete Decks;" +
                                      "delete CardsInHand;" +
	                                  "delete Hands;" +
	                                  "delete BlackJackTables;" +
                                      "delete Players;" +
                                      "delete MembershipEvents;";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }

            using (var conn = new SqlConnection(String.Format(@"Data Source=.\SQLEXPRESS;AttachDbFilename={0}\App_Data\ASPNETDB.mdf;Integrated Security=True;User Instance=True", WebSiteFileLocation.get_physical_path())))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "delete dbo.aspnet_Membership;" +
                                      "delete aspnet_Users;";                                      
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }
  
        public static void save_or_add<T>(T table_object)
        {
            using (var session = SessionFactory.GetNewSession())
            {
                using(var trans = session.BeginTransaction())
                {
                    session.SaveOrUpdate(table_object);
                    trans.Commit();
                }
            }
        }

        public static IEnumerable<T> find_all<T>()
        {
            using (var session = SessionFactory.GetNewSession())
            {                
                return session.Query<T>().ToList();                                      
            }
        }

        public static Guid get_user_id_from_membership_table_by(string email)
        {
            Guid user_id;

            using (var conn = new SqlConnection(String.Format(@"Data Source=.\SQLEXPRESS;AttachDbFilename={0}\App_Data\ASPNETDB.mdf;Integrated Security=True;User Instance=True", WebSiteFileLocation.get_physical_path())))
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "SELECT UserId " +
                                      "FROM aspnet_Membership " +
                                      "WHERE Email = @email";
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.CommandType = CommandType.Text;
                    user_id = new Guid(cmd.ExecuteScalar().ToString());
                }
            }

            return user_id;
        }
    }
}