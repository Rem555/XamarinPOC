using System;
using System.Collections.Generic;

namespace XamarinPOC
{
    public class DatabaseService : IDatabaseService
    {
        private List<Contact> _contacts;
        private List<Quote> _quotes;
        private List<Models.Action> _actions;

        public DatabaseService ()
        {
            _contacts = InitContacts();
            _quotes = InitQuotes();
            _actions = InitActions();
        }

        public void UpdateContact (Contact contact)
        {
            if (contact.Id == 0)
            {
                contact.Id = _contacts.Count + 1;
                _contacts.Add(contact);
            }
            else
            {
                var oldContact = _contacts.Find(c => c.Id == contact.Id);
                oldContact.Name = contact.Name;
                oldContact.Phone = contact.Phone;
            }
        }

        public void UpdateQuote (Quote quote)
        {
            if (quote.Id == 0)
            {
                quote.Id = _quotes.Count + 1;
                _quotes.Add(quote);
            }
            else
            {
                var oldQuote = _quotes.Find(c => c.Id == quote.Id);
                oldQuote.CustomerName = quote.CustomerName;
                oldQuote.Total = quote.Total;
            }
        }

        public List<Contact> GetContacts ()
        {
            return _contacts;
        }

        public List<Quote> GetQuotes ()
        {
            return _quotes;
        }

        public List<Models.Action> GetActions()
        {
            return _actions;
        }

        private List<Contact> InitContacts ()
        {
            return new List<Contact> {
                new Contact { Id = 1, Name = "Xam Consulting", Phone = "0404 865 350" },
                new Contact { Id = 2, Name = "Michael Ridland", Phone = "0404 865 350" },
                new Contact { Id = 3, Name = "Thunder Apps", Phone = "0404 865 350" },
            };
        }

        private List<Quote> InitQuotes ()
        {
            return new List<Quote> {
                new Quote { Id = 1, CustomerName = "Xam Consulting", Total = "$350.00" },
                new Quote { Id = 2, CustomerName = "Michael Ridland", Total = "$3503.00" },
                new Quote { Id = 3, CustomerName = "Thunder Apps", Total = "$3504.00" },
            };
        }

        private List<Models.Action> InitActions()
        {
            return new List<Models.Action> {
                new Models.Action {
                    Id = 1,
                    Title = "Woodland",
                    Description="First item",
                    ImageUrl = "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/23c1dd13-333a-459e-9e23-c3784e7cb434/2016-06-02_1049.png" },
                new Models.Action {
                    Id = 2,
                    Title = "Cleveland",
                    Description="Second item",
                    ImageUrl = "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/6b60d27e-c1ec-4fe6-bebe-7386d545bb62/2016-06-02_1051.png" },
                new Models.Action {
                    Id = 3,
                    Title = "Phoenix",
                     Description="Third item",
                   ImageUrl = "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/e8179889-8189-4acb-bac5-812611199a03/2016-06-02_1053.png" },
            };
        }
    }
}