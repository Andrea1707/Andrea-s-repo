#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#define CARDS 8
#define MAX_VALUE 11
int main(void)
{
  int a[CARDS],min,max;
  srand (time(NULL));
  for(int i=0;i < CARDS;i++)
  {
    do
    {
    a[i]=rand()%MAX_VALUE;
  }while(a[i] == 1 || a[i] == 0 );          //'cause there isn't card with 1 or 0 value'//
  }
  printf("My cards:\n");
  for(int i=0; i < CARDS; i++)
  {
    printf("%d ",a[i]);
  }
  printf("\n");
  min=MAX_VALUE;
  for(int i=1 ; i < CARDS ; i++)
  {
    if (min > a[i])
      {min=a[i];}
    if (max < a[i])
      {max=a[i];}
  }
  printf("Max number: %d\nMini number: %d\n",max,min);
  return 0;
}
