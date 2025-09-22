namespace OopGitHub_Branch_4princip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem pizza = new MenuItem();
            pizza.Name = "Pizza";
            pizza.SetPrice(80);
            pizza.ShowInfo();

            pizza.PlusPrice(10);
            pizza.ShowInfo();

            pizza.MinusPrice(20);
            pizza.ShowInfo();


            MenuItem burger = new MenuItem();
            burger.Name = "Big-Mac";
            burger.SetPrice(55);
            burger.ShowInfo();

            Drink cola = new Drink();
            cola.Name = "Cola-Zero";
            cola.SetPrice(20);
            cola.ShowInfo();
        }
    }
}

/*Varje branch ska:

 Ha egna commit-meddelanden
 Ha tydliga kommentarer i koden
 När du är klar – skapa en Pull Request till main                                                           
 PR:n ska beskriva vilken princip du implementerat och vad du lärt dig
             *             *                          *
 Du ska alltså ha 4 olika Pull Requests – en för varje princip.

*                            *                           *
_______________________main.class________utan OOP-principer___________________
Exempel på struktur:
main
BankAccount.cs(grundläggande klass utan OOP-principer)

__________________________encapsulation_______________________________________
Gör Balance privat, lägg till Deposit() och Withdraw()
inheritance
______________________________________________________________________________
Lägg till SavingsAccount : BankAccount
polymorphism
_______________________________________________________________________________
Skapa 1virtual och 2override metoder
3abstraction
Skapa 4abstract class Account och implementera den i underklasser */

//()()()(R)()(E)()(S)()(T)()(O)()R)()()(A)()()(N)()()()()()()()()()()()()()()()()()

/*____main.class________utan OOP-principer
Exempel på struktur:
main
MenuItem.cs(grundläggande klass utan OOP-principer)

________________________encapsulation_____________
Gör Price privat, lägg till SetPrice(), IncreasePrice() och DecreasePrice()

______________________________inheritance_______________
Lägg till Drink : MenuItem

_________________________polymorphism_____________
Skapa 1 virtual metod i MenuItem och 1 override metod i Drink

___________________________________abstraction_______________
Skapa abstract class ItemBase och implementera ShowInfo() i MenuItem och Drink
*/

