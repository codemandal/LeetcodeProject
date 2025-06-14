using System.Linq;

namespace LeetcodeProject
{
    public class _34Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {

        public static int[] SearchRange(int[] nums, int target)
        {
            int[] ans = new int[] { -1, -1 };

            if (nums.Length == 0)
                return ans;

          
            int stIndex = 0 ;
            int endIndex= nums.Length-1  ;

            if (nums[stIndex] == target && nums[endIndex] == target)
            {
                ans.SetValue(stIndex, 0);
                ans.SetValue(endIndex, 1);

                return ans;
            }

            while (stIndex < endIndex)
            {
                int mid = stIndex + (endIndex - stIndex)/ 2;

                if (nums[mid] > target)
                {
                    endIndex = mid-1;
                }
                else if (nums[mid] < target)
                {
                    stIndex = mid+1;
                    
                }
                else
                {
                    stIndex = endIndex = mid;
                }

            }
          
            int i = stIndex - 1;
            int j = endIndex + 1;

            while (i >= 0)
            {
                if (nums[i] == target)
                {
                    stIndex = i;
                    i--;
                }
                else
                    break;
            }

            while (j < nums.Length)
            {
                if (nums[j] == target)
                {
                    endIndex = j;
                    j++;
                }
                else
                    break;
            }

            if (nums[stIndex] == target && nums[endIndex] == target)
            {
                ans.SetValue(stIndex, 0);
                ans.SetValue(endIndex, 1);
            }



           


            return ans;
        }

        public static void FindIndex(int[] nums, int target, int startindex, int endindex)
        { 
         
            if (startindex == endindex)
                return;

            int mid = (startindex + endindex) / 2;

            if (nums[mid] > target)
                FindIndex(nums, target, 0, mid);
            else if (nums[mid] < target)
                FindIndex(nums, target, mid, nums.Length);
            else
            {
                startindex = endindex = mid;
            }
            //else
            //{
            //    if (startindex == 0 && endindex == 0)
            //        return;
            //    else
            //    {
            //        endindex = mid;
            //        startindex = mid;
                    
            //        while (startindex > 0 && endindex < nums.Length-1 && (nums[startindex] == target || nums[endindex] == target))
            //        {
            //            if (nums[startindex - 1] == target)
            //                startindex--;
            //            if (nums[endindex + 1] == target)
            //                endindex--;

            //        }
            //        return;

            //    }
            //    return;
            
            //}

        
        }

        //public static int[] SearchRange(int[] nums, int target)
        //{
        //    int[] ans = new int[] { -1, -1 };

        //    if (nums.Length == 0)
        //        return ans;

        //    int i = 0;
        //    int j = nums.Length - 1;
        //    while (i < nums.Length)
        //    {
        //        if (nums[i] == target && ans[0] == -1)
        //        {
        //            ans.SetValue(i, 0);
        //            break;
        //        }
        //        i++;

        //    }
        //    while (j >=0)
        //    {

        //        if (nums[j] == target && ans[1] == -1)
        //        {
        //            ans.SetValue(j, 1);
        //            break;
        //        }
        //        j--;


        //    }


        //    return ans;
        //}

        //public static int[] SearchRange(int[] nums, int target)
        //{
        //    int[] ans = new int[] { -1, -1 };

        //    if (nums.Length == 0)
        //        return ans;

        //    int n = nums.Length;
        //    int midi = n / 2;

        //    if (target > nums[midi] && midi > 0)
        //        SearchRange(nums.Skip(midi).ToArray(), target);
        //    else if (target < nums[midi] && midi > 0)
        //        SearchRange(nums.Take(midi).ToArray(), target);
        //    else if (target == nums[midi])
        //    {
        //        int i = midi - 1;
        //        int j = midi;
        //        ans.SetValue(midi, 0);
        //        ans.SetValue(midi, 1);

        //        while (nums[i] == target || nums[j] == target)
        //        {

        //            if (nums[i] == target)
        //            {
        //                ans.SetValue(i, 0);
        //                i--;
        //            }
        //            if (nums[j] == target)
        //            {
        //                ans.SetValue(j, 1);
        //                j++;
        //            }
        //        }
        //        return ans;

        //    }
        //    else
        //    {
        //        return ans;
        //    }
        //    return ans;
        //}
    }
}
