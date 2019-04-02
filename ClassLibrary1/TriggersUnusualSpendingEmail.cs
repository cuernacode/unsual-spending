using System;

namespace UnusualSpending.Classes
{
    public class TriggersUnusualSpendingEmail
    {
        private EmailSender emailSender;

        public TriggersUnusualSpendingEmail(EmailSender emailSender)
        {
            this.emailSender = emailSender;
        }

        public void Trigger(int userId)
        {
            emailSender.Email();
        }
    }
}
