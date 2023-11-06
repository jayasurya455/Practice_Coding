using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region Karat_Quest1
/*
You're creating a game with some amusing mini-games, and you've decided to make a simple variant of the game Mahjong.

In this variant, players have a number of tiles, each marked 0-9. The tiles can be grouped into pairs or triples of the same tile. For example, if a player has "33344466", the player's hand has a triple of 3s, a triple of 4s, and a pair of 6s. Similarly, "55555777" has a triple of 5s, a pair of 5s, and a triple of 7s.

A "complete hand" is defined as a collection of tiles where all the tiles can be grouped into any number of triples (zero or more) and exactly one pair, and each tile is used in exactly one triple or pair.

Write a function that takes a string representation of a collection of tiles in no particular order, and returns true or false depending on whether or not the collection represents a complete hand.

tiles_1 = "88844"           # True. Base case - a pair and a triple
8 - 3 
4 - 2
[]
[8,8,]
[3,2]

tiles_2 = "99"              # True. Just a pair is enough.
tiles_3 = "55555"           # True. The triple and a pair can be of the same tile value
tiles_4 = "22333333"        # True. A pair and two triples
tiles_5 = "73797439949499477339977777997394947947477993"
                            # True. 4 has two triples and a pair, other numbers have just triples
tiles_6 = "111333555"       # False. There are three triples, 111 333 555 but no pair
tiles_7 = "42"              # False. Two singles not forming a pair
tiles_8 = "888"             # False. A triple, no pair
tiles_9 = "100100000" 11 000 000      # False. A pair of 1 and two triples of 0, a left over 0
tiles_10 = "346664366"      # False. Three pairs and a triple
tiles_11 = "8999998999898"  # False. A triple of 8, three triples of 9, a leftover 8
tiles_12 = "17610177"       # False. Triples of 1, and 7, left over 6 and 0
tiles_13 = "600061166"      # False. A pair of 1, triple of 0, triple of 6, and 6 leftover
tiles_14 = "6996999"        # False. A pair of 6, a triple of 9 and another pair of 9
tiles_15 = "03799449"       # False. A pair of 4, triple of 9 and 0, 3, and 7 left over
tiles_16 = "64444333355556" # False. A pair of 6, two pairs each of 3, 4, 5
tiles_17 = "7"              # False. No pairs and 7 leftover

complete(tiles_1) => True
complete(tiles_2) => True
complete(tiles_3) => True
complete(tiles_4) => True
complete(tiles_5) => True
complete(tiles_6) => False
complete(tiles_7) => False
complete(tiles_8) => False
complete(tiles_9) => False
complete(tiles_10) => False
complete(tiles_11) => False
complete(tiles_12) => False
complete(tiles_13) => False
complete(tiles_14) => False
complete(tiles_15) => False
complete(tiles_16) => False
complete(tiles_17) => False

Complexity Variable
N - Number of tiles in the input string
*/
#endregion

#region Karat Quest 3
/* 

We are hosting a festival at our school, and we want to make sure we have enough people staffing our various events.

We will be given a list of schedules for our staff, and the number of people we need at an event per hour, similar to the following:

      #  start-end
staff_1 = [[5, 9], [12, 16]]
   # Hour   0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23
needed_1 = [0, 0, 0, 0, 0, 0, 1, 2, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0]

In this example, we have a person scheduled from hour 5 to hour 9, and a person from hour 12 to hour 16. These ranges are exclusive on the end; for example, the 5-9 person works during hours 5, 6, 7, and 8, but not hour 9.

We need 1 person staffed in hour 6, 2 in hour 7, 1 in hour 8, and 1 in each hour from 12 through 16.

We want to figure out which hours we do not have the necessary staff. In this case, we don't have two people staffed at hour 7. We also don't have anyone staffed at hour 16; the person staffed from 12-16 doesn't cover it. Our function should inform us that we are understaffed in hours 7 and 16.

Write a function that takes in a list of staff schedules and a list of numbers of needed staff, and returns the hours we are understaffed.

All test cases:
understaffed(staff_1, needed_1) => [7, 16]
understaffed(staff_2, needed_2) => []
understaffed(staff_3, needed_3) => [0, 1, 22, 23]
understaffed(staff_4, needed_4) => [0, 17]
understaffed(staff_5, needed_5) => [1, 2, 15]
understaffed(staff_6, needed_6) => [4, 22, 23]

Complexity variables:
n: the number of lists in staff

 */
#endregion

#region Karat Ques 4
/*
We're writing a software library to analyze data sets, and we'd like to examine whether two integer series of the same length move in the same direction or not.

Two data series are said to move "together" if:
* Every time the first series goes up, the second series goes up
* Every time the first series goes down, the second series goes down
* Every time the first series stays the same, the second series stays the same

For example, these two series move "together":
100 110 120 120 110 105
170 220 240 240 150 120

Two data series are said to move "opposite" if:
* Every time the first series goes up, the second series goes *down*
* Every time the first series goes down, the second series goes *up*
* Every time the first series stays the same, the second series stays the same

For example, these two series move "opposite"

100 110 120 120 110 105
170 150 120 120 200 250

Two series can move both same and opposite if both series always stay equal. For example:

300 300 300 300 300
500 500 500 500 500

Finally, a series can be neither of these if they do not move together, opposite, or both.

Write a function that takes in two series of numbers of the same length and returns one of the following:
* "together" if the two series move in the same direction
* "opposite" if the two series move in opposite directions
* "both" if the two series move both, same and opposite
* "neither" if the two series move neither, same nor opposite

series1 = [100, 110, 120, 120, 110, 105]
series2 = [170, 220, 240, 240, 150, 120]
series3 = [170, 150, 120, 120, 200, 250]
series4 = [100, 200, 100, 200, 100, 200]
series5 = [100, 200, 100, 200, 100, 0]
series6 = [300, 200, 100, 200, 100, 200]
series7 = [200, 200]
series8 = [100, 100]
series9 = [100, 150]
series10 = [300, 300, 300, 300, 300]
series11 = [500, 500, 500, 500, 500]
series12 = [170, 220, 240, 235, 150, 120]
series13 = [100, 50]

All test cases:
trending(series1, series1)   => together
trending(series1, series2)   => together
trending(series1, series3)   => opposite
trending(series1, series4)   => neither
trending(series4, series5)   => neither
trending(series4, series6)   => neither
trending(series7, series8)   => both
trending(series9, series7)   => neither
trending(series7, series13)  => neither
trending(series10, series11) => both
trending(series1, series12)  => neither

Complexity variables:
N = the number of items in each series
*/

#endregion
public class HelloWorld
{
    public static void Main(string[] args)
    {
        //string string1 = "";
        //Console.WriteLine("Please Enter Input : ");
        //string1 = Console.ReadLine();
        //FindPrime(Int16.Parse(string1));
        //ReverseString(string1);
        //ReverseWordOrder(string1);

        #region Karat_Quest1
        var tiles_1 = "88844";
        var tiles_2 = "99";
        var tiles_3 = "55555";
        var tiles_4 = "22333333";
        var tiles_5 = "73797439949499477339977777997394947947477993";
        var tiles_6 = "111333555";
        var tiles_7 = "42";
        var tiles_8 = "888";
        var tiles_9 = "100100000";
        var tiles_10 = "346664366";
        var tiles_11 = "8999998999898";
        var tiles_12 = "17610177";
        var tiles_13 = "600061166";
        var tiles_14 = "6996999";
        var tiles_15 = "03799449";
        var tiles_16 = "64444333355556";
        var tiles_17 = "7";
        #endregion

        #region karat_Quest2
        var logs1 = new string[][]{
    new []{"200", "user_1", "resource_5"},
    new []{"3", "user_1", "resource_1"},
    new []{"620", "user_1", "resource_1"},
    new []{"620", "user_3", "resource_1"},
    new []{"34", "user_6", "resource_2"},
    new []{"95", "user_9", "resource_1"},
    new []{"416", "user_6", "resource_1"},
    new []{"58523", "user_3", "resource_1"},
    new []{"53760", "user_3", "resource_3"},
    new []{"58522", "user_22", "resource_1"},
    new []{"100", "user_3", "resource_6"},
    new []{"400", "user_6", "resource_2"},
};

        var logs2 = new string[][]{
    new []{"357", "user", "resource_2"},
    new []{"1262", "user", "resource_1"},
    new []{"1462", "user", "resource_2"},
    new []{"1060", "user", "resource_1"},
    new []{"756", "user", "resource_3"},
    new []{"1090", "user", "resource_3"},
};

        var logs3 = new string[][]{
    new []{"300", "user_10", "resource_5"},
};

        var logs4 = new string[][]{
    new []{"1", "user_96", "resource_5"},
    new []{"1", "user_10", "resource_5"},
    new []{"301", "user_11", "resource_5"},
    new []{"301", "user_12", "resource_5"},
    new []{"603", "user_12", "resource_5"},
    new []{"1603", "user_12", "resource_7"},
};

        var logs5 = new string[][]{
    new []{"300", "user_1", "resource_3"},
    new []{"599", "user_1", "resource_3"},
    new []{"900", "user_1", "resource_3"},
    new []{"1199", "user_1", "resource_3"},
    new []{"1200", "user_1", "resource_3"},
    new []{"1201", "user_1", "resource_3"},
    new []{"1202", "user_1", "resource_3"},
};
        #endregion

        #region karat Quest 3
        int[][] staff_1 = new int[][] {
            new int[] {5, 9},
            new int[] {12, 16}
        };
        int[] needed_1 = new int[] { 0, 0, 0, 0, 0, 0, 1, 2, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 };
        int[][] staff_2 = new int[][] {
            new int[] {0, 10},
            new int[] {10, 20},
            new int[] {20, 24}
        };
        int[] needed_2 = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        int[][] staff_3 = new int[][] {
            new int[] {0, 10},
            new int[] {10, 20},
            new int[] {20, 24}
        };
        int[] needed_3 = new int[] { 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2 };
        int[][] staff_4 = new int[][] {
            new int[] {1, 4},
            new int[] {1, 3},
            new int[] {5, 15},
            new int[] {7, 15},
            new int[] {13, 16},
            new int[] {14, 23},
            new int[] {15, 19},
            new int[] {13, 21},
            new int[] {0, 6},
            new int[] {6, 10}
        };
        int[] needed_4 = new int[] { 3, 1, 2, 0, 0, 0, 0, 3, 1, 0, 0, 0, 0, 1, 3, 2, 0, 4, 0, 0, 0, 0, 0, 0 };
        int[][] staff_5 = new int[][] {
            new int[] {12, 19},
            new int[] {13, 23},
            new int[] {3, 12},
            new int[] {5, 9},
            new int[] {4, 11},
            new int[] {7, 9},
            new int[] {2, 6},
            new int[] {6, 11},
            new int[] {7, 17},
            new int[] {8, 11}
        };
        int[] needed_5 = new int[] { 0, 3, 2, 1, 0, 2, 4, 4, 3, 1, 3, 1, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0 };
        int[][] staff_6 = new int[][] {
            new int[] {13, 22},
            new int[] {16, 19},
            new int[] {3, 8},
            new int[] {2, 4},
            new int[] {19, 21},
            new int[] {10, 16},
            new int[] {15, 18},
            new int[] {3, 7},
            new int[] {0, 4},
            new int[] {1, 9}
        };
        int[] needed_6 = new int[] { 0, 0, 3, 1, 5, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 2, 3, 0, 0, 0, 0, 1, 2 };
        #endregion

        #region Karat Ques 4
        int[] series1 = new int[] { 100, 110, 120, 120, 110, 105 };
        int[] series2 = new int[] { 170, 220, 240, 240, 150, 120 };
        int[] series3 = new int[] { 170, 150, 120, 120, 200, 250 };
        int[] series4 = new int[] { 100, 200, 100, 200, 100, 200 };
        int[] series5 = new int[] { 100, 200, 100, 200, 100, 0 };
        int[] series6 = new int[] { 300, 200, 100, 200, 100, 200 };
        int[] series7 = new int[] { 200, 200 };
        int[] series8 = new int[] { 100, 100 };
        int[] series9 = new int[] { 100, 150 };
        int[] series10 = new int[] { 300, 300, 300, 300, 300 };
        int[] series11 = new int[] { 500, 500, 500, 500, 500 };
        int[] series12 = new int[] { 170, 220, 240, 235, 150, 120 };
        int[] series13 = new int[] { 100, 50 };
        #endregion

        returnArray_Karat2(logs1);
        //ReturnTrueOrFalse_Karat1(tiles_5);
        //understaffed(staff_1, needed_1);
        //Console.WriteLine(trending(series1, series1));
    }
    static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }
    internal static void ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        for (int i = 0, j = str.Length - 1; i < j; i++, j--)
        {
            charArray[i] = str[j];
            charArray[j] = str[i];
        }
        string reversedstring = new string(charArray);
        Console.WriteLine(reversedstring);
    }
    //karat Interview Ques
    internal static void ReturnTrueOrFalse_Karat1(string word)
    {
        bool printV = false;
        char[] num = word.ToCharArray();
        Dictionary<string, int> countedValues = new Dictionary<string, int>();

        for (int i = 0; i < num.Length; i++)
        {
            int count = 0;
            if (!countedValues.ContainsKey(num[i].ToString()))
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        count++;
                    }
                }
                countedValues[num[i].ToString()] = count;
            }
        }

        foreach(var item in countedValues)
        {
            if (item.Value % 3 == 1)
            {
                printV = false;
                break;
            }
            else if (printV == false && (item.Value == 2 || item.Value % 3 == 2))
            {
                printV = true;
            }
            else if (printV == true && (item.Value == 2 || item.Value % 3 == 2))
            {
                printV = false;
                break;
            }
        }

        Console.WriteLine(printV);
    }

    internal static void ReverseWordOrder(string str)
    {
        int i;
        StringBuilder reverseSentence = new StringBuilder();
        int Start = str.Length - 1;
        int End = str.Length - 1;
        while (Start > 0)
        {
            if (str[Start] == ' ')
            {
                i = Start + 1;
                while (i <= End)
                {
                    reverseSentence.Append(str[i]);
                    i++;
                }
                reverseSentence.Append(' ');
                End = Start - 1;
            }
            Start--;
        }
        for (i = 0; i <= End; i++)
        {
            reverseSentence.Append(str[i]);
        }
        Console.WriteLine(reverseSentence);
    }

    internal static void findallsubstring(string str)
    {
        for (int i = 0; i < str.Length; ++i)
        {
            StringBuilder subString = new StringBuilder(str.Length - i);
            for (int j = i; j < str.Length; ++j)
            {
                subString.Append(str[j]);
                Console.Write(subString + " ");
            }
        }
    }
    internal static void chkPalindrome(string str)
    {
        bool flag = false;
        for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
        {
            if (str[i] != str[j])
            {
                flag = false;
                break;
            }
            else
                flag = true;
        }
        if (flag)
        {
            Console.WriteLine("Palindrome");
        }
        else
            Console.WriteLine("Not Palindrome");
    }
    internal static void FindPrime(int number)
    {
        bool flag = true;
        if (number == 1) flag=false;
        if (number == 2) flag= true;
        if (number % 2 == 0) flag = false;
        var squareRoot = (int)Math.Floor(Math.Sqrt(number));
        for (int i = 3; i <= squareRoot; i += 2)
        {
            if (number % i == 0) flag = false;
        }

        if (flag)
        {
            Console.WriteLine("Prime");
        }
        else
        {
            Console.WriteLine("Not Prime");
        }
    }

    //Karat interview 2nd question
    internal static void returnArray_Karat2(string[][] inputs)
    {
        List<UserProp> output = new List<UserProp>();
        for (int i = 0; i < inputs.Length; i++)
        {
            if (output.Count == 0) {
                UserProp userValue = new UserProp();
                userValue.userName = inputs[i][1];
                userValue.greater = inputs[i][0];
                userValue.lesser = inputs[i][0];
                output.Add(userValue);
            }
            for (int j = 0; j < output.Count; j++)
            {
                var name = inputs[i][1];
                List<UserProp> CheckBool = output.Where(obj => obj.userName == inputs[i][1]).ToList();
                if (CheckBool.Count == 0)
                {
                    UserProp userValue = new UserProp();
                    userValue.userName = inputs[i][1];
                    userValue.greater = inputs[i][0];
                    userValue.lesser = inputs[i][0];
                    output.Add(userValue);
                }
                else
                {
                    if (Convert.ToInt32(output[output.FindIndex(obj => obj.userName == inputs[i][1])].greater) < Convert.ToInt32(inputs[i][0]))
                    {
                        output[output.FindIndex(obj => obj.userName == inputs[i][1])].greater = inputs[i][0];
                    }
                    else if (Convert.ToInt32(output[output.FindIndex(obj => obj.userName == inputs[i][1])].lesser) > Convert.ToInt32(inputs[i][0]))
                    {
                        output[output.FindIndex(obj => obj.userName == inputs[i][1])].lesser = inputs[i][0];
                    }
                }

            }
        }
        Console.WriteLine('{');
        foreach (var item in output)
        {
            Console.WriteLine("{0} : [{1},{2}]",item.userName,item.lesser,item.greater);
        }
        Console.WriteLine('}');

    }

    // Karat 3
    internal static void understaffed(int[][] staffs, int[] needed)
    {
        List<int> result = new List<int>(new int[24]);
        List<int> actResult = new List<int>();
        for (int i = 0; i < staffs.Length; i++)
        {
            for (var j = staffs[i][0]; j < staffs[i][1]; j++)
            {
                ++result[j];
            }
        }


        for (int i = 0; i < result.Count; i++)
        {
            if (result[i] < needed[i] && needed[i] != 0)
            {
                actResult.Add(i);
            }
        }
        Console.WriteLine("result got compiled successfully:");
        foreach (int item in actResult)
        {
            Console.WriteLine(item.ToString());
        }
    }

    //Karat Ques 4
    internal static string trending(int[] seriesA, int[] seriesB)
    {
        string seriesType = "";
        bool together = false;
        bool opposite = false;
        bool both = false;
        bool neither = false;

        for (int a = 0; a < seriesA.Length; a++)
        {
            if (a != 0)
            {
                if ((!opposite && !both && !neither) && (seriesA[a - 1] < seriesA[a] && seriesB[a - 1] < seriesB[a]) || (seriesA[a - 1] > seriesA[a] && seriesB[a - 1] > seriesB[a]))
                {
                    together = true;
                }
                else if ((!together && !both && !neither) && ((seriesA[a - 1] > seriesA[a] && seriesB[a - 1] < seriesB[a]) || (seriesA[a - 1] < seriesA[a] && seriesB[a - 1] > seriesB[a])))
                {
                    opposite = true;

                }
                else if ((!together && !opposite && !neither) && (seriesA[a - 1] == seriesA[a] && seriesB[a - 1] == seriesB[a]))
                {
                    both = true;
                }
                else
                {
                    neither = true;
                    together = false;
                    opposite = false;
                    both = false;
                }
            }
        }

        Console.WriteLine("Toge: {0}, opp: {1}, both: {2}, nei: {3}", together.ToString(), opposite.ToString(), both.ToString(), neither.ToString());
        if (neither == true)
        {
            seriesType = "Neither";
        }
        else if (both == true)
        {
            seriesType = "Both";
        }
        else if (together == true)
        {
            seriesType = "Together";
        }
        else if (opposite == true)
        {
            seriesType = "Opposite";
        }
        return seriesType;

    }

}

public class UserProp
{
    public string? userName { get; set; }
    public string? greater { get; set; }
    public string? lesser { get; set; }
}