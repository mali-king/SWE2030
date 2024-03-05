/*
//Increment and Decrement

int value1 = 1;
value1 = value1 + 1;
Console.WriteLine("First Increment:" + value1);
value1 += 1;
Console.WriteLine("Second Increment:" + value1);
value1++;
Console.WriteLine("Third Increment :" + value1);
value1 = value1 - 1;
Console.WriteLine("First Decrement:" + value1);
value1 -= 1;
Console.WriteLine("Second Decrement:" + value1);
value1--;
Console.WriteLine("Third Decrement:" + value1);
*/

/*
//increment and Decrement order

int value2 = 1;
value2++;
Console.WriteLine("First:" + value2);
Console.WriteLine("Second:" + value2++);
Console.WriteLine("Third:" + value2);
Console.WriteLine(" First:" + (++value2));

int value3 = 1;
++value3;
value3++;
Console.WriteLine("First:" + value3);
*/

/*
//Converting to Celcius

int fahrenheit1 = 94;
decimal temperature1 = ((fahrenheit1 - 32) * 5m / 9);
Console.WriteLine("The temperature is " + temperature1 + " degree celcius");

int fahrenheit2 = 94;
decimal temperature2 = ((fahrenheit2 - 32m) * 5m / 9m);
Console.WriteLine("The temperature is " + Math.Round(temperature2) + " degree celcius");
*/

/*
//Overriding

Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);
Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
*/

/*
//dice if else

Random dice1 = new Random();
int roll1 = dice1.Next(1, 7);
int roll2 = dice1.Next(1, 7);
int roll3 = dice1.Next(1, 7);
int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} +{roll2} + {roll3}");

if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled tripples! +6 bonus to total!");
    total += 6;
}
else if (((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}
*/

/*
//Exercise: If else

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
}
if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
}
if (daysUntilExpiration < 1)
{
    Console.WriteLine("Your subscription has expired!");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine("Renew now and save" + discountPercentage + " %!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine("Your subscription expires in:" + daysUntilExpiration + " days.");
    Console.WriteLine("Renew now and save" + discountPercentage + " %!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription expires in:" + daysUntilExpiration + " days.");
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
*/

/*
//Array Challenge

string[] orderIds = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string items in orderIds)
{

    if (items.StartsWith("B"))
    {

        Console.WriteLine(items);
    }
}
*/

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
/*
Random random2 = new Random();
string[] orderIDs2 = new string[5];

for (int i = 0; i < orderIDs2.Length; i++)
{
    int prefixValue2 = random2.Next(65, 70);
    string prefix2 = Convert.ToChar(prefixValue2).ToString();
    string suffix2 = random2.Next(1, 1000).ToString("000");

    orderIDs2[i] = prefix2 + suffix2;
}

foreach (var orderID2 in orderIDs2)
{
    Console.WriteLine(orderID2);
}
*/

/*
//Data types

Console.WriteLine("Signed integral type:");
Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");
*/

/*
//Array reverse and Sort

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("Sorted ....");
Array.Sort(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("Reverse ....");
Array.Reverse(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}
*/

/*
Array.Clear();
public static void Clear(Array array, int index, int length);
//Array .clear

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
if (pallets[0] != null)
{
    Console.WriteLine($"After: {pallets[0].ToLower()}");
}

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

/*
// String Challenge

string s = "The quick brown fox jumps over the lazy dog";

string[] subs = s.Split(' ');

foreach (var sub in subs)
{
    char[] value = sub.ToCharArray();
    Array.Reverse(value);
    string result = String.Join("", value);
    Console.WriteLine(result);
}
*/

/*
// HashSet Challenge

Set<int> abNumbers = new HashSet<int>();

for (int i = 0; i < A.Length; i++)
{
    abNumbers.Add(Math.Abs(A[i]));
}
return abNumbers.size();
*/

/*
using System;

class Solution {
    public int solution(int X, int Y, int D) 
    {
        int jumpProgress= X;
        int count=0;
        while (jumpProgress<Y)
        {
            jumpProgress+=D;
            count++;
        }
        return count;
    }
}
*/

/*
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        var dummyList = new ListNode();
        var head = new ListNode();
        head = dummyList;

        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                dummyList.next = list1;
                dummyList = dummyList.next;
                list1 = list1.next;
            }
            else
            {
                dummyList.next = list2;
                dummyList = dummyList.next;
                list2 = list2.next;
            }
        }
        if (list1 != null)
        {
            dummyList.next = list1;
        }
        else if (list2 != null)
        {
            dummyList.next = list2;
        }
        return head.next;
    }
}
*/

/*
public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        int[] result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 1; i < nums.Length; i++)
            {
                if (nums[i] + nums[i + j] == target)
                {
                    result[0] = i;
                    result[1] = i + j;
                    return result;
                }
            }
        }
        return result;
    }
}
*/
