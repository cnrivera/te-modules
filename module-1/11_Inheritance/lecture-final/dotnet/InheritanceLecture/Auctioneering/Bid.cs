﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLecture.Auctioneering
{
    public class Bid 
    {
        /// <summary>
        /// The bidder name.
        /// </summary>
        public string Bidder { get; }

        /// <summary>
        /// The bid amount.
        /// </summary>
        public int BidAmount { get; }
        /// <summary>
        /// Constructor for Bid object. Each Bid requires a bidder and bidAmount
        /// </summary>
        /// <param name="bidder">Who is bidding</param>
        /// <param name="bidAmount">How much bid is for</param>
        public Bid(string bidder, int bidAmount)
        {
            this.Bidder = bidder;
            this.BidAmount = bidAmount;
        }

        public override string ToString()
        {
            return Bidder + ": $" + BidAmount + " my class: "+base.ToString(); //show that base.ToString calls System.Object to string (since that's my parent
        }
    }
}
