// See https://aka.ms/new-console-template for more information
using FrezQuestGame;

Console.WriteLine("Hello, World!");
Weapon sword001 = new Weapon("Fire God", 86, "Sword");
Weapon bow001 = new Weapon("Spleef Bow", 40, "Bow");
Hero id001 = new Hero("Hawai", 100);
Dragon id002 = new Dragon("Smaug", 300);
Dragon id003 = new Dragon("Pizduk", 10);
double firstAttack = id001.Bite();
double secondAttack = id002.Incinerate(id001);
id003.TakeDamage(firstAttack);
if (id003.HP <= 0)
{
    Console.WriteLine($"{id003.Name}, was killed by {id001.Name}..");
}
else
{
    Console.WriteLine($"{id003.Name} HP's was is -{firstAttack} and ostalos' = {id003.HP}");
}
id001.TakeDamage(secondAttack);
if (id001.HP <= 0)
{
    Console.WriteLine($"{id001.Name}, was killed by {id002.Name}..");
}
else
{
    Console.WriteLine($"{id001.Name} HP's was is -{secondAttack} and ostalos' = {id001.HP}");
}