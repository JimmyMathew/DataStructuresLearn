//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructures
//{
//    class Array
//    {
        
//       public  List<String> weekDayHour = new List<string>();
//        public String getNextOpeningHour(List<String> weekdayHour, int position) 
//        {
//            if (position == weekdayHour.Count())
//                position = 0;
//            String weekDayHourValue = weekdayHour[position];
//            if (weekDayHourValue.Contains("Closed"))
//                weekDayHourValue =  getNextOpeningHour(weekdayHour, position + 1);
//            else
//                weekDayHourValue =  weekdayHour[position];

//            return weekDayHourValue;
//        }
//        static void Main(string[] args)
//        {
//            Array arrayObj = new Array();
//            arrayObj.weekDayHour.Add("18:00 AM - 9:00 PM");
//            arrayObj.weekDayHour.Add("28:00 AM - 9:00 PM");
//            arrayObj.weekDayHour.Add("38:00 AM - 9:00 PM");
//            arrayObj.weekDayHour.Add("48:00 AM - 9:00 PM");
//            arrayObj.weekDayHour.Add("5Closed");
//            arrayObj.weekDayHour.Add("6Closed");
//            arrayObj.weekDayHour.Add("7Closed");
//            Console.WriteLine(arrayObj.getNextOpeningHour(arrayObj.weekDayHour, 6));
//            Console.ReadKey();
//        }
//}
//}
