public class Solution {
    public bool IsPowerOfFour(int num) {
        //num > 0 check if it is a positive number
        //num&(num-1) check if only contains only one 1 in the number
        //(num & 0x55555555) != 0 remove the pow of 2 but not pow of 4, e.g. 8,
        return num > 0 && (num&(num-1)) == 0 && (num & 0x55555555) != 0;
    }
}