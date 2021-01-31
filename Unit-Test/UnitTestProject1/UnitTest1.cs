using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabAssignment;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addTest() //Answer 1.1.
        {
            Program p = new Program();
            double result = p.add(10, 10, 10,10);
            Assert.AreEqual(result, 40);//Correct value
           // Assert.AreEqual(result, 4);//Wrong value
        }
        [TestMethod]
        public void subTest()//Answer 1.2.
        {
            Program p = new Program();
            double result = p.sub(10, 5, 2, 1);
            Assert.AreEqual(result, 2);//Correct value
            //Assert.AreEqual(result, 4);//Wrong value
        }
        [TestMethod]
        public void multiTest()//Answer 1.3.
        {
            Program p = new Program();
            double result = p.multi(10, 5, 2, 1);
            Assert.AreEqual(result, 100);//Correct value
            //Assert.AreEqual(result, 4);//Wrong value
        }
        [TestMethod]
        public void diviTest()//Answer 1.4.
        {
            Program p = new Program();
            double result = p.divi(10, 5, 2, 1);
            Assert.AreEqual(result, 1);//Correct value
            //Assert.AreEqual(result, 4);//Wrong value
        }
        [TestMethod]
        public void writeAsReverseTest()//Answer 2
        {
            Program p = new Program();
            string result = p.writeAsReverse("Erdinç");
            Assert.AreEqual(result, "çnidrE");//Correct value
            //Assert.AreEqual(result, "Erdinç");//Wrong value
        }
        [TestMethod]
        public void facTest()//Answer 3
        {
            Program p = new Program();
            double result = p.fac(3);
            Assert.AreEqual(result, 6);//Correct value
            //Assert.AreEqual(result, 4);//Wrong value
        }
        [TestMethod]
        public void getUserNameTestForAcademicianClass()//Answer 4.1
        {
            Academician a1 = new Academician();
            Academician a2 = new Academician();
            Academician a3 = new Academician();
            Academician a4 = new Academician();

            string resultUserName = a1.getUserName("rdas");
            Assert.AreEqual(resultUserName, "rdas");//Correct value
            //Assert.AreEqual(resultUserName, "rrdas");//Wrong value

            string resultUserName2 = a2.getUserName("mbaykara");
            Assert.AreEqual(resultUserName2, "mbaykara");//Correct value
            //Assert.AreEqual(resultUserName2, "rrdas");//Wrong value

            string resultUserName3 = a3.getUserName("tbalakus");
            Assert.AreEqual(resultUserName3, "tbalakus");//Correct value
            //Assert.AreEqual(resultUserName3, "rrdas");//Wrong value

            string resultUserName4 = a4.getUserName("bpolat");
            Assert.AreEqual(resultUserName4, "bpolat");//Correct value
            //Assert.AreEqual(resultUserName4, "rrdas");//Wrong value

        }
        [TestMethod]
        public void getPasswordTestForAcademicianClass()//Answer 4.2
        {
            Academician a1 = new Academician();
            Academician a2 = new Academician();
            Academician a3 = new Academician();
            Academician a4 = new Academician();

            string resultPassword = a1.getPassword("785123");
            Assert.AreEqual(resultPassword, "785123");//Correct value
            //Assert.AreEqual(resultPassword, "785223");//Wrong value

            string resultPassword2 = a2.getPassword("45786");
            Assert.AreEqual(resultPassword2, "45786");//Correct value
            //Assert.AreEqual(resultPassword2, "45782");//Wrong value

            string resultPassword3 = a3.getPassword("123456");
            Assert.AreEqual(resultPassword3, "123456");//Correct value
            //Assert.AreEqual(resultPassword3, "12456");//Wrong value

            string resultPassword4 = a4.getPassword("456128");
            Assert.AreEqual(resultPassword4, "456128");//Correct value
            //Assert.AreEqual(resultPassword4, "456228");//Wrong value

        }
        [TestMethod]
        public void getUNPTestForAcademicianClass()//Answer 4.3
        {
            Academician a1 = new Academician();
            Academician a2 = new Academician();
            Academician a3 = new Academician();
            Academician a4 = new Academician();

            string resultUserNameNSurname = a1.getUserNameNSurname("Resul Daş");
            Assert.AreEqual(resultUserNameNSurname, "Resul Daş");//Correct value
            //Assert.AreEqual(resultUserNameNSurname, "785223");//Wrong value

            string resultUserNameNSurname2 = a2.getUserNameNSurname("Muhammet Baykara");
            Assert.AreEqual(resultUserNameNSurname2, "Muhammet Baykara");//Correct value
            //Assert.AreEqual(resultUserNameNSurname2, "45782");//Wrong value

            string resultUserNameNSurname3 = a3.getUserNameNSurname("Talha Burak Alakuş");
            Assert.AreEqual(resultUserNameNSurname3, "Talha Burak Alakuş");//Correct value
            //Assert.AreEqual(resultUserNameNSurname3, "12456");//Wrong value

            string resultUserNameNSurname4 = a4.getUserNameNSurname("Berna Polat");
            Assert.AreEqual(resultUserNameNSurname4, "Berna Polat");//Correct value
            //Assert.AreEqual(resultUserNameNSurname4, "456228");//Wrong value

        }
        [TestMethod]
        public void getTitleTestForAcademicianClass()//Answer 4.4
        {
            Academician a1 = new Academician();
            Academician a2 = new Academician();
            Academician a3 = new Academician();
            Academician a4 = new Academician();

            string resultTitle = a1.getTitle("Prof. Dr.");
            Assert.AreEqual(resultTitle, "Prof. Dr.");//Correct value
            //Assert.AreEqual(resultTitle, "785223");//Wrong value

            string resultTitle2 = a2.getTitle("Dr. Öğr. Üyesi");
            Assert.AreEqual(resultTitle2, "Dr. Öğr. Üyesi");//Correct value
            //Assert.AreEqual(resultTitle2, "785223");//Wrong value

            string resultTitle3 = a1.getTitle("Arş. Gör.");
            Assert.AreEqual(resultTitle3, "Arş. Gör.");//Correct value
            //Assert.AreEqual(resultTitle3, "785223");//Wrong value

            string resultTitle4 = a1.getTitle("Arş. Gör.");
            Assert.AreEqual(resultTitle4, "Arş. Gör.");//Correct value
            //Assert.AreEqual(resultTitle4, "785223");//Wrong value

        }
        [TestMethod]
        public void getMailTestForAcademicianClass()//Answer 4.5
        {
            Academician a1 = new Academician();
            Academician a2 = new Academician();
            Academician a3 = new Academician();
            Academician a4 = new Academician();

            string resultMail = a1.getMail("resuldas@gmail.com");
            Assert.AreEqual(resultMail, "resuldas@gmail.com");//Correct value
            //Assert.AreEqual(resultMail, "785223");//Wrong value

            string resultMail2 = a2.getMail("muhammetbaykara23@gmail.com");
            Assert.AreEqual(resultMail2, "muhammetbaykara23@gmail.com");//Correct value
            //Assert.AreEqual(resultMail2, "785223");//Wrong value

            string resultMail3 = a3.getMail("burak.alakus@gmail.com");
            Assert.AreEqual(resultMail3, "burak.alakus@gmail.com");//Correct value
                                                               //Assert.AreEqual(resultMail3, "785223");//Wrong value

            string resultMail4 = a4.getMail("brnpolatt@gmail.com");
            Assert.AreEqual(resultMail4, "brnpolatt@gmail.com");//Correct value
            //Assert.AreEqual(resultMail4, "785223");//Wrong value
        }
    }
}
