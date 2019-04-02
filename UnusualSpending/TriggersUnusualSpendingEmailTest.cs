using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using UnusualSpending.Classes;

namespace Tests
{
    public class TriggersUnusualSpendingEmailTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ShouldSendEmailWhenUnusualSpendingHappens()
        {
            int userId = 1;
            int year = 2019;
            int month = 3;
            int previousMonth = 2;
            Mock<EmailSender> mockEmailSender = new Mock<EmailSender>();
            mockEmailSender.Setup(x => x.Email());



            TriggersUnusualSpendingEmail spending = new TriggersUnusualSpendingEmail(mockEmailSender.Object);
            spending.Trigger(userId);


            mockEmailSender.Verify(x => x.Email(), Times.Once());
        }


    }
}