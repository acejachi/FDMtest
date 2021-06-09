using System;
using System.Collections.Generic;

public class Solution {
    public string ConvertNum(int num) {
        string outp="";
        if (num == 1){
            outp = "\n  |\n  |\n  ";
        }
		else if (num ==2){
			outp = " _\n _|\n|_ \n  ";
		}
		else if (num ==3){
			outp = " _\n _|\n _| \n  ";
		}
		else if (num ==4){
			outp = "\n|_|\n  |\n ";
		}
		else if (num ==5){
			outp = " _\n|_ \n _|\n  ";
		}
		else if (num ==6){
			outp = " _\n|_\n|_| \n  ";
		}
		else if (num == 7){
            outp = " _\n  |\n  |\n  ";
        }
		else if (num ==8){
			outp = " _\n|_|\n|_| \n  ";
		}
		else if (num ==9){
			outp = " _\n|_|\n _| \n  ";
		}
		else if (num ==0){
			outp = " _\n| |\n|_| \n  ";
		}
        return outp;
    }
	public int[] GetDigits(int num) {
	Stack <int> stack = new Stack<int>();
		int newnum = num;
		while (newnum > 0) {
		int digit = newnum % 10;
			stack.Push(digit);
			newnum /= 10;
		}
		
		return stack.ToArray();
	}

    public void Main() {
		int a = 1234567890;
		int [] digits = GetDigits(a);
		int i;
		for(i = 0; i<digits.Length;i++){
        string str = ConvertNum(digits[i]);
        Console.WriteLine(str);
		}
    }
}