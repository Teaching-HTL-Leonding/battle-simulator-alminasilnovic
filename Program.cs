Console.Clear();
int health1 = 0;
int health2 = 0;
int attack1 = 0;
int attack2 = 0;
int speed1 = 0;
int speed2 = 0;
const int PIRATE_HEALTH = 20;
const int PIRATE_SPEED = 3;
const int PIRATE_ATTACK = 3;
const int GHOST_WARRIOR_HEALTH = 50;
const int GHOST_WARRIOR_ATTACK = 8;
const int GHOST_WARRIOR_SPEED = 1;
const int STONE_CHEWER_SPEED = 5;
const int STONE_CHEWER_HEALTH = 50;
const int STONE_CHEWER_ATTACK = 2;
const string PIRATE = "pirate";
const string STONE_CHEWER = "stone chewer";
const string GHOST_WARRIOR = "ghost warrior";
const string PLAYER1_WINS = "Congrats Player 1, you won!";
const string PLAYER2_WINS = "Congrats Player 2, you won!";
const string DRAW = "It is a Draw.";


Console.WriteLine("Player 1, choose you character: " + PIRATE + ", " + STONE_CHEWER + " , " + GHOST_WARRIOR);
string player1 = Console.ReadLine()!;
Console.WriteLine("Player 2, choose you character.");
string player2 = Console.ReadLine()!;

switch (player1)
{
    case PIRATE:
        health1 += PIRATE_HEALTH;
        attack1 += PIRATE_ATTACK;
        speed1 += PIRATE_SPEED;
        break;
    case GHOST_WARRIOR:
        health1 += GHOST_WARRIOR_HEALTH;
        attack1 += GHOST_WARRIOR_ATTACK;
        speed1 += GHOST_WARRIOR_SPEED;
        break;
    case STONE_CHEWER:
        health1 += STONE_CHEWER_HEALTH;
        attack1 += STONE_CHEWER_ATTACK;
        speed1 += STONE_CHEWER_SPEED;
        break;
    default:
        Console.WriteLine("Wrong Input.");
        break;
}

switch (player2)
{
    case PIRATE:
        health2 += PIRATE_HEALTH;
        attack2 += PIRATE_ATTACK;
        speed2 += PIRATE_SPEED;
        break;
    case GHOST_WARRIOR:
        health2 += GHOST_WARRIOR_HEALTH;
        attack2 += GHOST_WARRIOR_ATTACK;
        speed2 += GHOST_WARRIOR_SPEED;
        break;
    case STONE_CHEWER:
        health2 += STONE_CHEWER_HEALTH;
        attack2 += STONE_CHEWER_ATTACK;
        speed2 += STONE_CHEWER_SPEED;
        break;
    default:
        Console.WriteLine("Wrong Input.");
        break;
}

while (health1 > 0 && health2 > 0)
{
    health1 -= attack2 * speed2;
    health2 -= attack1 * speed1;
}

if (health1 > 0)
{
    Console.WriteLine(PLAYER1_WINS);
}
else if (health2 > 0)
{
    Console.WriteLine(PLAYER2_WINS);
}
else
{
    Console.WriteLine(DRAW);
}


Console.WriteLine("Press any key to exit.");
Console.ReadKey();
Console.Clear();