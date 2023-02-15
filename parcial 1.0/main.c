#include <stdio.h>

int main () {
   int arr1[] = {5, 10, 2, 8, 7};
   int arr2[] = {2, 9, 4, 6, 3};
   int arr3[10], i, j, k;

   //ordenar primer arreglo en orden descendente
   for (i= 0; i < 5; i++){
    for (j = i + 1; j < 5; j++){
        if  (arr1[i] < arr1 [j]){
         int temp = arr1 [i];
         arr1 [i] = arr1[j];
         arr1[j] = temp;
        }
      }
   }

//ordenar el segundo array en orden descendente
for (i = 0; i < 5; i++) {
    for (j = i + 1; j < 5; j++) {
      if  (arr2[i] < arr2 [j]){
         int temp = arr2 [i];
         arr2 [i] = arr2[j];
         arr2[j] = temp;
       }
    }
 }

  // Fusionar los dos arrays ordenados en uno solo
  i = 0, j = 0, k = 0;
  while (i < 5 && j < 5) {
    if (arr1[i] > arr2[j]) {
      arr3[k] = arr1[i];
      i++;
    } else {
      arr3[k] = arr2[j];
      j++;
    }
    k++;
  }

  // Agregar los elementos restantes del primer array
  while (i < 5) {
    arr3[k] = arr1[i];
    i++;
    k++;
  }

  // Agregar los elementos restantes del segundo array
  while (j < 5) {
    arr3[k] = arr2[j];
    j++;
    k++;
  }

  // Imprimir los resultados
  printf("El array ordenado es: ");
  for (i = 0; i < 10; i++) {
    printf("%d ", arr3[i]);
  }

  printf("\nEl array arr1 en arr3 es: ");
  for (i = 0; i < 5; i++) {
    printf("%d ", arr3[i]);
  }

  printf("\nEl array arr2 en arr3 es: ");
  for (i = 5; i < 10; i++) {
    printf("%d ", arr3[i]);
  }

  printf("\n");
  return 0;
}
