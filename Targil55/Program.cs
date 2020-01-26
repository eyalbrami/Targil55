using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
  כיתבו תוכנית המדמה פעולה של מכונה למכירת כרטיסים לקולנוע. בתחילה התוכנית (המכונה) מודיעה למשתמש מה המחיר של כרטיס (יוגדר כקבוע וערכו 50 שקלים) ואז שואלת אותו כמה כרטיסים ברצונו לקנות. לאחר שהיא מקבלת את תשובתו, היא כותבת לו מה המחיר הכולל שהוא צריך לשלם. היא "מקבלת" את כספו (קוראת מהקלט כמה הכניס). אם הסכום מדוייק - היא מדפיסה הודעה על מספר הכרטיסים שמחכים לו בקופה. אם חסר כסף, היא מודיעה למשתמש כמה כסף חסר. אם המשתמש הכניס יותר מידי כסף, המכונה מדפיסה הודעה על מספר הכרטיסים המחכים לו בקופה, וגם מודיעה לו על העודף המגיע לו. חובה לבדוק תקינות הקלט. את הקוד כיתבו במחלקה שתקרא TicketMachine. על הפונקציה להיות סטטית.

     */
namespace Targil55
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTickets;
            TicketMachine ticketMachine = new TicketMachine();
            Console.WriteLine("Welcome - Ticket Price " + ticketMachine.GetPrice() + " $");
            Console.WriteLine("Hello, please choose number of tickets ");
            numOfTickets = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello, please choose number of tickets " + ticketMachine.GetTotal(numOfTickets));
            Console.ReadLine();
        }

    }
}
