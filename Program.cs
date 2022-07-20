using System;
internal class Program
{
    static void Main(string[] args)
    {
        int health = 50, maxHealth = 100;
        int mana = 40, maxMana = 100;

        drawBar(health, maxHealth, 15,3);

        drawBar(mana, maxMana, 15,4);
    }

    static void drawBar(int value, int maxValue, int yPosition, int xPosition)
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
