#include <stdio.h>

int main () {
   int cubo [4][4] = { {1, 1, 1, 1},
                       {2, 2, 2, 2},
                       {3, 3, 3, 3},
                       {4, 4, 4, 4} };

      int sum_columna[4] = {0};
      int sum_fila[4] = {0};

      // sumar los numeros en columnas
      for(int i = 0; i < 4; i++) {
        for(int j = 0; j < 4; j++){
            sum_columna[i] += cubo[j][i];
        }
      }

     //sumar los numeros en fila
        for(int i = 0; i < 4; i++) {
        for(int j = 0; j < 4; j++){
            sum_fila[i] += cubo[i][j];
           }
        }
     //mostrar los resultados
     printf("suma por columna:\n");
     for(int i = 0; i < 4; i++){
        printf("%d", sum_columna[i]);
     }
     printf("\n");

       printf("suma por fila:\n");
     for(int i = 0; i < 4; i++){
        printf("%d", sum_fila[i]);
     }
     printf("\n");

     return 0;
   }
