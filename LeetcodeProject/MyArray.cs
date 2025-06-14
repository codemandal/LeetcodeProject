using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class MyArray
    {


        public static int[] InsertAtIndex(int[] a, int i, int val)
        {
            int n = a.Length - 1;
            for (int j = n - 1; j >= i; j--)
            {
                a[j + 1] = a[j];

            }
            a[i] = val;
            return a;
        }
        public static int[] Insertfirst(int[] a, int val)
        {
            int n = a.Length - 1;
            for (int j = n - 1; j >= 0; j--)
            {
                a[j + 1] = a[j];

            }
            a[0] = val;
            return a;
        }
        public static int[] Insertlast(int[] a, int val, int size)
        {

            a[size] = val;
            return a;
        }
        public static void Traverse(int[] a, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        public static int[] RemoveAtIndex(int[] a, int i)
        {
            int n = a.Length - 1;
            for (int j = i; j < n; j++)
            {
                a[j] = a[j + 1];

            }
            return a;
        }

        public static void RemoveLast(int[] a)
        {

        }

        public static int[] RemoveFirst(int[] a)
        {
            int n = a.Length - 1;
            for (int j = 0; j < n - 1; j++)
            {
                a[j] = a[j + 1];
            }
            return a;
        }


        public static int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }

            }

            return k;

        }

        public static int RemoveDuplicates(int[] nums)
        {

            int j = 0;

            for (int i = 1; i < nums.Length; i++)
            {

                if (nums[i] != nums[j])
                {
                    j++;
                    nums[j] = nums[i];

                }

            }

            return j + 1;

        }
        public static int RemoveDuplicatesx(int[] nums)
        {
            // this will not rearrange the array

            int ans = 1;
            int k = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != k)
                {
                    k = nums[i];
                    ans++;
                }
            }

            return ans;

        }

        public static bool CheckifdoubleExist(int[] arr) {
            List<double> visited = new List<double>();
            for (int i = 0; i < arr.Length; i++)
            {
                double x = (double)arr[i] / 2;
                if (visited.Contains(arr[i] * 2) || (visited.Contains(x)))
                    return true;

                visited.Add(arr[i]);




            }
            return false;


        }

        public static bool ValidMountainArray(int[] arr)
        {
            int peak = 0;
            int l = 0;
            int r = arr.Length - 1;
            while (l < arr.Length - 1 && arr[l] < arr[l + 1])
                l += 1;
            while (r > 0 && arr[r - 1] > arr[r])
                r -= 1;
            if (l > 0 && l == r && r < arr.Length - 1)
                return true;
            else
                return false;
        }

        public static int[] ReplacementElementsx(int[] arr) {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                if (i < n - 1)
                    arr[i] = arr.Skip(i + 1).Max();
                else
                    arr[i] = -1;

            }

            return arr;
        }
        //without using max
        public static int[] ReplacementElements(int[] arr)
        {
            int n = arr.Length - 1;
            int max = arr[n];

            for (int i = n - 1; i >= 0; i--)
            {
                if (arr[i] > max)
                    max = arr[i];
                else
                    arr[i] = max;

            }
            for (int i = 0; i < n; i++)
            {
                arr[i] = arr[i + 1];

            }
            arr[n] = -1;
            return arr;
        }

        public static int[] ReplacementElementsOptimum(int[] arr)
        {
            int curr_max = arr[arr.Length - 1];
            int temp;
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                temp = arr[i];
                arr[i] = curr_max;
                if (temp > curr_max) { curr_max = temp; }
            }
            arr[arr.Length - 1] = -1;
            return arr;
        }

        public static int[] DeleteDuplicatesInPlace(int[] nums)
        {
            int j = 0, n = nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                    nums[j++] = nums[i];
            }
            nums[j++] = nums[n - 1];

            return nums;
        }

        public static int[] MoveZeros(int[] nums)
        {
            int j = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }
            for (int i = j; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

            return nums;
        }

        public static int[] MergeTwoSortedArrays(int[] nums1, int[] nums2)
        {

            int j = 0;
            int i = 0;
            List<int> nums3 = new List<int>();

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    nums3.Add(nums1[i]);
                    i++;
                }
                else {
                    nums3.Add(nums2[j]);
                    j++;
                }

            }

            return nums3.Concat(nums1.Skip(i).Concat(nums2.Skip(j))).ToArray();

        }

        public static double FindMedianSortedArrayx(int[] nums1, int[] nums2)
        {
            int j = 0;
            int i = 0;
            List<int> nums3 = new List<int>();

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                {
                    nums3.Add(nums1[i]);
                    i++;
                }
                else
                {
                    nums3.Add(nums2[j]);
                    j++;
                }

            }

            while (i < nums1.Length)
            {
                nums3.Add(nums1[i]);
                i++;
            }

            while (j < nums2.Length)
            {
                nums3.Add(nums2[j]);
                j++;
            }



            double ans;
            if (nums3.ToArray().Length % 2 == 0)
            {


                ans = (double)(nums3[nums3.Count / 2] + nums3[nums3.Count / 2 - 1]) / 2;
            }
            else
            {
                ans = (double)nums3[(nums3.Count - 1) / 2];
            }
            
            
            return ans;
            
        }


        public static double FindMedianSortedArray(int[] nums1, int[] nums2) {

            if (nums1.Length > nums2.Length)
            {
                return FindMedianSortedArray(nums2, nums1);
            }
            int lo = 0;
            int hi = nums1.Length;
            if (nums1.Length == 0)
            {
                if (nums2.Length % 2 == 0)
                {
                    return (double)(nums2[nums2.Length / 2] + nums2[nums2.Length / 2 - 1]) / 2;
                }
                else
                    return (double)nums2[(nums2.Length - 1) / 2];
            }
            while (lo <= hi)
            {
                int cut1 = (lo + hi) / 2;
                int cut2 = ((nums1.Length + nums2.Length + 1) / 2) - cut1;

                int l1 = (cut1 == 0) ? int.MinValue : nums1[cut1 - 1]; // maxleftx
                int l2 = (cut2 == 0) ? int.MinValue : nums2[cut2 - 1]; // maxkefty
                int r1 = (cut1 == nums1.Length) ? int.MaxValue : nums1[cut1];//minrightx
                int r2 = (cut2 == nums2.Length) ? int.MaxValue : nums2[cut2];// minrighty

                if (l1 > r2)
                {
                    hi = cut1 - 1;
                }
                else if (l2 > r1)
                {
                    lo = cut1 + 1;

                }
                else
                {
                    return ((nums1.Length + nums2.Length) % 2 == 0) ? (double)(Math.Max(l1, l2) + Math.Min(r1, r2)) / 2 : (double)Math.Max(l1, l2);
                }

            }

            return 0;

        }

        public static double[] getMediansofRunningArray(int[] array)
        {
            //PriorityQueue<int, int> lowers = new System.Collections.Generic.PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
            //PriorityQueue<int, int> highers = new System.Collections.Generic.PriorityQueue<int, int>();
            SortedSet<int> lowers = new SortedSet<int>();
            SortedSet<int> highers = new SortedSet<int>();

            double[] medians = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];
                addNumber(number, lowers, highers);
                rebalance(lowers, highers);
                medians[i] = getMedians(lowers, highers);
            }
            return medians;
        }

        public static void addNumber(int number, SortedSet<int> lowers, SortedSet<int> highers)
        {
            if (lowers.Count == 0 || number < lowers.Max())
            {
                lowers.Add(number);
            }
            else
                highers.Add(number);

        }
        public static void rebalance(SortedSet<int> lowers, SortedSet<int> highers)
        { 
            SortedSet<int> bigger = lowers.Count > highers.Count ? lowers : highers;
            SortedSet<int> smaller = lowers.Count > highers.Count ? highers : lowers;

            if (bigger.Count - smaller.Count >= 2) {
                smaller.Add(bigger.Max);
                bigger.Remove(bigger.Max);
            }
        
        }

        public static double getMedians(SortedSet<int> lowers, SortedSet<int> highers) {
            SortedSet<int> bigger = lowers.Count > highers.Count ? lowers : highers;
            SortedSet<int> smaller = lowers.Count > highers.Count ? highers : lowers;
            if (bigger.Count == smaller.Count)
                return (double)((bigger.Min + lowers.Max) / 2);
            else
                return bigger.Min();
        }




    }

  
}
