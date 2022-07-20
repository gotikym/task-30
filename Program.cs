using System;
internal class Program
{
    static void Main(string[] args)
    {
        int health = 50;
        int maxHealth = 100;
        int mana = 40;
        int maxMana = 100;

        DrawBar(health, maxHealth, 15,3);

        DrawBar(mana, maxMana, 15,4);
    }

    static void DrawBar(int value, int maxValue, int yPosition, int xPosition)
    {
        int convertToUnit = 10;
        value /= convertToUnit;
        maxValue /= convertToUnit;
        string bar = "";

        for (int i = 0; i < value; i++)
        {
            bar += "#";
        }

        Console.SetCursorPosition(yPosition, xPosition);
        Console.Write('[');
        Console.Write(bar);
        bar = "";

        for (int i = value; i < maxValue; i++)
        {
            bar += '_';
        }

        Console.Write(bar + ']');
    }
}
