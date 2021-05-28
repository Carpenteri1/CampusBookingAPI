using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampusBookingAPI.Data.TestData
{
    public class TestData
    {
        public string className { get; set; }
        public string timeStart { get; set; }
        public string timeEnd { get; set; }
        public string info { get; set; }
        public string location { get; set; }
        public string room { get; set; }


        /*
        public static TestData GetTestDataById(int id)
        {
            return CreateTestDatas().Where(item => item.id == id).FirstOrDefault();
        }*/

        public static IEnumerable<TestData> GetTestDatas()
        {
            return CreateTestDatas();
        }
        public static TestData[] CreateTestDatas()
        {
            TestData[] testData =
           {
                    new TestData
                    {
                        className = "sut-19",
                        timeStart = new DateTime(2021, 2, 22, 18, 30, 0).Hour + ":" + new DateTime(2021, 2, 22, 18, 30, 0).Minute,
                        timeEnd = new DateTime(2021, 2, 22, 20, 0, 0).Hour + ":" + new DateTime(2021, 2, 22, 20, 0, 0).Minute,
                        info = "Redovisning",
                        location = "B-hus",
                        room = "B-202"
                    },
                    new TestData
                    {
                      className = "sut-20",
                      timeStart =  new DateTime(2021, 2, 23, 15, 0, 0).Hour + ":" + new DateTime(2021, 2, 23, 15, 0, 0).Minute,
                      timeEnd = new DateTime(2021, 2, 23, 17, 0, 0).Hour + ":" + new DateTime(2021, 2, 23, 17, 0, 0).Minute,
                      info = "Mjukvaruutveckling",
                      location = "C-hus",
                      room = "c-356"
                    },
                    new TestData
                    {
                        className = "sut-18",
                        timeStart = new DateTime(2021, 2, 25, 11, 0, 0).Hour + ":" + new DateTime(2021, 2, 25, 11, 0, 0).Minute,
                        timeEnd = new DateTime(2021, 2, 25, 14, 0, 0).Hour + ":" + new DateTime(2021, 2, 25, 14, 0, 0).Minute,
                        info = "studiebesök",
                        location = "A-hus",
                        room = "A-101"
                    }
                };
            return testData.ToArray();
        }
    }
}
