using System;
public class BinarySearchProgram {
  public static Boolean BinarySearch(int[] arr, int target){
    int start = 0;
    int end = arr.Length-1;
    
    while(start <= end){
    int mid = start+(end-start)/2;
      
      if(arr[mid] == target){
        return true;
      }else if(arr[mid] < target){
          start = mid+1;
      }else{
        end = mid-1;
      }
    }
    
    return false;
    
  }
    public static void Main(String[] args) {
      int[] arr = {1,3,4,6,12,21,35,54,76,78,98};
      int target = 54;
      
      if(BinarySearch(arr, target)){
      Console.WriteLine("Element is Present");
        
      }
      else{
        Console.WriteLine("Element is not Present");
      }
      
  }
}
