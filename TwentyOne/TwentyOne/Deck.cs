using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()// constructor = method thats called as soon as an object is created
        {
            //Cards = new List<Card>();    //---individual entries are long and take up space
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);    // --- use a foreach loop to fill the deck list

            Cards = new List<Card>(); // instaniate its property Cards as a new empty list of cards
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };//---List with values
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"  //---list with values
            };
           //---create a nested foreach loop--------
            foreach(string face in Faces)
            // foreach item in faces, we loop thru 4 times (one for each suit in inner loop
            {
                foreach(string suit in Suits)
                {            
                    Card card = new Card();  //--for each inner loop we create a new card for new value(s)
                    card.Suit = suit;        //--give that card a suit value, first clubs then hearts ect thru loop
                    card.Face = face;        //--give that card the face value its on in its iteration of this outer loop
                    Cards.Add(card);         //--Add that card to the list Cards of Deck and go to next suit in list with inner loop
                }
            }


        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {           
            for (int i = 0; i < times; i++)
            {              
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }        
    }
}
