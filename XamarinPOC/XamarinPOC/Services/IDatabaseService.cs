using System;
using System.Collections.Generic;

namespace XamarinPOC
{
    public interface IDatabaseService
    {
        List<Contact> GetContacts ();

        void UpdateContact (Contact contact);

        List<Quote> GetQuotes ();

        void UpdateQuote (Quote quote);

        List<Models.Action> GetActions();
    }
}