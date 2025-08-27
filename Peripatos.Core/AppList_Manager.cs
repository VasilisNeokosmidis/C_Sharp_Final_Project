using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peripatos.Core
{
    public static class AppList_Manager
    {
        public static List<Beach> List_Beaches = new List<Beach>();
        public static List<Sight> List_Sights = new List<Sight>();
        public static List<Restaurant> List_Restaurants = new List<Restaurant>();

        public static void Initialize_Lists()
        {
            Initialize_List_Beaches();
            Initialize_List_Sights();
            Initialize_List_Restaurants();
        }

        public static void Initialize_List_Beaches()
        {
            DataTable Beach_Datatable = Database.Select_All_Places_Of_Type("Παραλία");

            for (int i = 0; i < Beach_Datatable.Rows.Count; i++)
            {
                string title = Beach_Datatable.Rows[i]["Name"].ToString();
                string description = Beach_Datatable.Rows[i]["Description"].ToString();
                List<byte[]> ImageList = Database.Select_All_PlaceImages_Per_Name(Convert.ToInt32(Beach_Datatable.Rows[i]["PlaceID"]));

                Beach new_beach = new Beach(title, description, ImageList);
                List_Beaches.Add(new_beach);
            }

        }

        public static void Initialize_List_Sights()
        {
            DataTable Sight_Datatable = Database.Select_All_Places_Of_Type("Αξιοθέατο");

            for (int i = 0; i < Sight_Datatable.Rows.Count; i++)
            {
                string title = Sight_Datatable.Rows[i]["Name"].ToString();
                string description = Sight_Datatable.Rows[i]["Description"].ToString();
                List<byte[]> ImageList = Database.Select_All_PlaceImages_Per_Name(Convert.ToInt32(Sight_Datatable.Rows[i]["PlaceID"]));

                Sight new_sight = new Sight(title, description, ImageList);
                List_Sights.Add(new_sight);
            }

        }


        public static void Initialize_List_Restaurants()
        {
            DataTable Sight_Datatable = Database.Select_All_Places_Of_Type("Εστιατόριο");

            for (int i = 0; i < Sight_Datatable.Rows.Count; i++)
            {
                string title = Sight_Datatable.Rows[i]["Name"].ToString();
                string description = Sight_Datatable.Rows[i]["Description"].ToString();
                List<byte[]> ImageList = Database.Select_All_PlaceImages_Per_Name(Convert.ToInt32(Sight_Datatable.Rows[i]["PlaceID"]));

                Restaurant new_restaurant = new Restaurant(title, description, ImageList);
                List_Restaurants.Add(new_restaurant);
            }

        }
    }
}
