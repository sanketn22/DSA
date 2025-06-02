## DSA

#Insertion Sort

                 * swap with the adjacent element 
                 * till they are in the correct position
                 * or the index reaches the first position
                 * eg, starting at 0th index arr[0] = 2
                 * ------------ i = 0 ---------
                 * therefore j= 0 and we will not enter the loop
                 * next element i = 1 arr[1] = 4
                 * j = 1
                 * arr[j] = arr[1] = 4 
                 * arr[j-1] = arr[1-1] = arr[0] = 2
                 * compare 2 > 4 : false -- no swap required
                 * arr[0] = 2; arr[1] = 4
                 * [2,4,1,5,3]
                 * ----------- i = 2 ---------------
                 * j = 2
                 * arr[j] = arr[2] = 1
                 * arr[j-1] = arr[2-1] = arr[1] = 4
                 * compare 4 > 1 : true -- swap 4 and 3
                 * arr[1] = 1; arr[2] = 4
                 * reduce j
                 * j now = 1
                 * arr[j] = arr[1] = 1
                 * arr[j-1] = arr[1-1] = arr[0] = 2
                 * compare 2 > 1 : true -- swap
                 * arr[0] = 1 ; arr[1] = 2 ; arr[2] = 4
                 * j -- ; j = 0 ; while condition becomes false, exits while loop
                 * [1,2,4,5,3]
                 * ----------- i ++ : i = 3 -----------
                 * j = 3
                 * arr[j] = 5
                 * arr[j-1] = arr[3-1] = arr[2] = 4
                 * compare 4 > 5 : false -- no swap
                 * [1,2,4,5,3]
                 * ----------- i ++ : i = 4 -----------
                 * j = 4
                 * arr[j] = arr[4] = 3
                 * arr[j-1] arr[4-1] = arr[3] = 5
                 * compare 5>3 : true -- swap
                 * [1,2,4,3,5]
                 * j = 3
                 * arr[j] = arr[3] = 3
                 * arr[j-1] arr[3-1] = arr[2] = 4
                 * compare 4 > 3 : true -- swap
                 * [1,2,3,4,5]
                 * j -- : j = 2
                 * arr[j] = arr[2] = 3
                 * arr[j-1] = arr[2-1] = arr[1] = 2
                 * compare 2 > 3 false -- no swap : while condition false, exit while loop
                 * [1,2,3,4,5]
                 *