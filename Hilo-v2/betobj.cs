using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilo_v2
{
    public class betobj
    {
        public string identifier { get; set; }
        public decimal amount { get; set; }
        public string currency { get; set; }
        public string game { get; set; }
        public string guess { get; set; }
        public Card startCard { get; set; }
        public string seed { get; set; }
    }
    public class Card
    {
        public string rank { get; set; }
        public string suit { get; set; }
    }
    public class Data
    {
        public Betdata data { get; set; }
        public List<Errors> errors { get; set; }
    }
    public class Errors
    {
        public List<string> path { get; set; }
        public string message { get; set; }
        public string errorType { get; set; }
        public string data { get; set; }
    }

    public class ActiveData
    {
        public User data { get; set; }
        public List<Errors> errors { get; set; }
    }
    public class User
    {
        public Active user { get; set; }
    }
    public class Active
    {
        public string id { get; set; }
        public string name { get; set; }
        public Hilobet activeCasinoBet { get; set; }
        public List<Balances> balances { get; set; }
    }
    public class Balances
    {
        public Available available { get; set; }
    }
    public class Available
    {
        public decimal amount { get; set; }
        public string currency { get; set; }
    }
    public class Betdata
    {
        public Hilobet hiloBet { get; set; }
        public Hilobet hiloNext { get; set; }
        public Hilobet hiloCashout { get; set; }
        public object rotateSeedPair { get; set; }
    }
    public class Hilobet
    {
        public string id { get; set; }
        public string iid { get; set; }
        public double payoutMultiplier { get; set; }
        public decimal amount { get; set; }
        public decimal payout { get; set; }
        public string updatedAt { get; set; }
        public string currency { get; set; }
        public Active user { get; set; }
        public State state { get; set; }
    }
    public class State
    {
        public List<Rounds> rounds { get; set; }
        public Card startCard { get; set; }

    }
    public class Rounds
    {
        public Card card { get; set; }
        public string guess { get; set; }
        public double payoutMultiplier { get; set; }
        public string updatedAt { get; set; }

    }
}
