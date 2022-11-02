// Игра в кости двух друзей
Random random = new Random();// Генератор случайных чисел
List<int> totalScore = new() { 0, 0 };
//totalScore[0] - общий счет первого игрока firstPlayerWins
//totalScore[1] - общий счет второго игрока firstPlayerWins
int totalGames = 10;
int currentGame = 1;
while (currentGame <= totalGames)
{
    currentGame += 1;
    int firstPlayerRolls = 50;
    int firstPlayerWins = 0;

    int secondPlayerRolls = firstPlayerRolls;
    int secondPlayerWins = 0;
    while (firstPlayerRolls > 0)
    {
        int firstRoll = random.Next(1, 7);
        int secondRoll = random.Next(1, 7);
        if (firstRoll + secondRoll = 7)
        {
            firstPlayerWins += 1;
        }
        firstPlayerRolls -= 1;
    }
    while (secondPlayerRolls > 0)
    {
        int firstRoll = random.Next(1, 7);
        int secondRoll = random.Next(1, 7);
        if (firstRoll + secondRoll = 8)
        {
            secondPlayerWins += 1;
        }
        secondPlayerRolls -= 1;
    }
    Console.WriteLine(string.Format("Победа первого игрока: {0} Победы второго игрока: {1}",
                                     firstPlayerWins,
                                     secondPlayerWins));
    if (firstPlayerWins > secondPlayerWins) totalScore[0]++;
    else totalScore[1]++;
}
Console.WriteLine(string.Join(",", totalScore));