const int STONE_CHEWER_HEALTH = 50;
const int PIRATE_HEALTH = 20;
const int GHOST_WARRIOR_HEALTH = 20;
const int OUTWOLDER_HEALTH = 15;
const int MONSER_KNIGHT_HEALTH = 15;
const int Dark_Goblin_HEALTH = 10;

const int STONE_CHEWER_ATTACK = 8;
const int PIRATES_ATTACK = 3;
const int GHOST_WARRIOR_ATTACK = 2;
const int OUTWORLDER_ATTACK = 2;
const int MONSTER_KNIGHT_ATTACK = 4;
const int DARK_GOBLIN_ATTACK = 1;

const int STONE_CHEWER_SPEED = 1;
const int Pirat_SPEED = 3;
const int Ghost_Warrior_SPEED = 5;
const int OUTWOLDER_SPEED = 10;
const int MONSTER_KNIGHT_SPEED = 3;
const int DARK_GOBLIN_SPEED = 3;

const int STONE_CHEWER_AMOR = 3;
const int PIRATE_AMOR = 10;
const int GHOST_WARRIOR_AMOR = 2;
const int OUTWOLDER_AMOR = 2;
const int MONSER_KNIGHT_AMOR = 3;
const int DARK_GOBLIN_AMOR = 8;

const int DRAW = 0;
    
Console.Clear();

Console.WriteLine("Player 1, pick your character (pirate, stone chewer, ghost warrior, outworlder, monster knight and dark goblin): ");
string firstcharacter = Console.ReadLine()!;

Console.WriteLine("Player 2, pick your character (pirate, stone chewer, ghost warrior, outworlder, monster knight and dark goblin): ");
string secondcharacter = Console.ReadLine()!;

int SPEED1 = 0;
int ATTACK1 = 0;
int HEALTH1 = 0;
int AMOR1 = 0;

int SPEED2 = 0;
int ATTACK2 = 0;
int HEALTH2 = 0;
int AMOR2 = 0;

switch (firstcharacter)
{
    case "stone chewer":
        HEALTH1 = STONE_CHEWER_HEALTH;
        ATTACK1 = STONE_CHEWER_ATTACK;
        SPEED1 = STONE_CHEWER_SPEED;
        AMOR1 = STONE_CHEWER_AMOR;
        break;

    case "pirate":
        HEALTH1 = PIRATE_HEALTH;
        HEALTH1 = PIRATES_ATTACK;
        HEALTH1 = Pirat_SPEED;
        HEALTH1 = PIRATE_AMOR;
        break;

    case "ghost warrior":
        HEALTH1 = GHOST_WARRIOR_HEALTH;
        ATTACK1 = GHOST_WARRIOR_ATTACK;
        SPEED1 = Ghost_Warrior_SPEED;
        AMOR1 = GHOST_WARRIOR_AMOR;
        break;

    case "outworlder":
        HEALTH1 = OUTWOLDER_HEALTH;
        HEALTH1 = OUTWORLDER_ATTACK;
        HEALTH1 = OUTWOLDER_SPEED;
        HEALTH1 = OUTWOLDER_AMOR;

        break;

    case "monster knight":
        HEALTH1 = MONSER_KNIGHT_HEALTH;
        ATTACK1 = MONSTER_KNIGHT_ATTACK;
        SPEED1 = MONSTER_KNIGHT_SPEED;
        AMOR1 = MONSER_KNIGHT_AMOR;
        break;

    case "dark goblin":
        HEALTH1 = Dark_Goblin_HEALTH;
        ATTACK1 = DARK_GOBLIN_ATTACK;
        SPEED1 = DARK_GOBLIN_SPEED;
        AMOR1 = DARK_GOBLIN_AMOR;
        break;
}

switch (secondcharacter)
{
    case "stone chewer":
        HEALTH2 = STONE_CHEWER_HEALTH;
        ATTACK2 = STONE_CHEWER_ATTACK;
        SPEED1 = STONE_CHEWER_SPEED;
        AMOR2 = STONE_CHEWER_AMOR;
        break;

    case "pirate":
        HEALTH2 = PIRATE_HEALTH;
        ATTACK2 = PIRATES_ATTACK;
        SPEED2 = Pirat_SPEED;
        AMOR2 = PIRATE_AMOR;
        break;

    case "ghost warrior":
        HEALTH2 = GHOST_WARRIOR_HEALTH;
        ATTACK2 = GHOST_WARRIOR_ATTACK;
        SPEED2 = Ghost_Warrior_SPEED;
        AMOR2 = GHOST_WARRIOR_AMOR;
        break;

    case "outworlder":
        HEALTH2 = OUTWOLDER_HEALTH;
        ATTACK2 = OUTWORLDER_ATTACK;
        SPEED2 = OUTWOLDER_SPEED;
        AMOR2 = OUTWOLDER_AMOR;
        break;

    case "monster knight":
        HEALTH2 = MONSER_KNIGHT_HEALTH;
        ATTACK2 = MONSTER_KNIGHT_ATTACK;
        SPEED2 = MONSTER_KNIGHT_SPEED;
        AMOR2 = MONSER_KNIGHT_AMOR;
        break;

    case "dark goblin":
        HEALTH2 = Dark_Goblin_HEALTH;
        ATTACK2 = DARK_GOBLIN_ATTACK;
        SPEED2 = DARK_GOBLIN_SPEED;
        AMOR2 = DARK_GOBLIN_AMOR;
        break;
}


while (HEALTH1 > 0 && HEALTH2 > 0)
{
    HEALTH1 = HEALTH1 + AMOR1 - ATTACK2 * SPEED2;
    HEALTH2 = HEALTH2 + AMOR2 - ATTACK1 * SPEED1;
}

if (HEALTH1 > 0)
{
    Console.WriteLine("Congratulation, Player 1 wins!");
}
else if (HEALTH2 > 0)
{
    Console.WriteLine("Congratulation, Player 2 wins!");
}
else if (HEALTH1 == DRAW || HEALTH2 == DRAW)
{
    Console.WriteLine("Nobody won, please play again");
}


Console.WriteLine("Press any key to continue.");

Console.ReadKey();
Console.Clear();