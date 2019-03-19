using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaCartDelivery
{
    public class Delivery
    {
        bool[] delivery(int[] order, int[][] shoppers)
        {
            // Figure out which shopper, if any, can take the order
            // Order delivery time must be between 20 and 35 minutes to meet target Figure
            // (shopper_distance + store_distance) / speed + store_time
            // 

            int order_distance = order[0];
            int order_waitTime = order[1];
            // int order_buffer = order[2];
            int order_windowTime = order[2];

            // Bool array to store results
            // of whether or not shoppers will take a given order
            bool[] takeOrder = new bool[shoppers.Length];

            // ((300 + 200) / 40) + 5)

            // int calculation = (shopperDistance + storeDistance) / speed + store_time;

            int windowTime = 0;

            int index = 0;

            foreach (int[] shopper in shoppers)
            {
                int shopper_distance = shopper[0];
                int shopper_travelSpeed = shopper[1];
                int shopper_storeTime = shopper[2];

                int result = (shopper_distance + order_distance) / shopper_travelSpeed + shopper_storeTime;

                index++;

            }

            // Index through delivery array
            // 
            /*
            for (int index = 0; index < 2; index++)
            {
                // Order properties
                int storeDistance = order[0];    
                int customerReadyTime = order[1];    
                int waitTime = order[2];

                // Index through shoppers array
                for (int shopperIndex = 0; shopperIndex < delivery[index].Length; shopperIndex++)
                {

                }
            }
            */

            // Loop through shoppers array
            // Nested for loop

            /*
            for (int index = 0; index < shoppers.length(); index++)
            {
                for (int shopper_index = 0; shopper_index < shoppers[index].length(); shopper_index++)
                {
                    // Determine if shopper can take the order
                    // Order cannot be received early, 
                    // and cannot be received more than 15 minutes late
                    if (calculation >= 20 && calculation <= 35)
                    {
                        shopper[i] = true;
                    }
                    else
                    {
                        shopper[i] = false;
                    }
                }
            }
            */

            // Return bool array 
            return takeOrder;
        }
    }
}
