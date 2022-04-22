#include <emscripten.h>
#include <stdio.h>

EMSCRIPTEN_KEEPALIVE
unsigned long factorial(int x)    
{    
 unsigned long i, fact=1, number=x;    
    for(i=1;i<=number;i++){    
      fact=fact*i;    
  }  
return fact;  
}