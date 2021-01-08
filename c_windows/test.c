#include <stdio.h>
#include <stdlib.h>
#define EXPORT __declspec(dllexport)
// #define EXPORT  

EXPORT int one () {
  return 1;
}

EXPORT int two () {
	return 2;
}

EXPORT int addOne (int i) {
	return i + 1;
}

EXPORT int addTwo (int i) {
	return i + two ();
  
}
typedef struct { 
    int x;
    int y; 
} Point;

EXPORT int SumPoint ( Point a){
  return a.x + a.y;
}
EXPORT Point makePoint ( int xSet , int ySet){
  Point r = {
    xSet,
    ySet
  };

  return r;
}

EXPORT void HelloWorld () {
    //Printf does not wortk
	printf("Hello world from gcc via f#\n");
}

int main() {
  // printf() displays the string inside quotation
  printf("Hello, World version 2!\n");
  Point r = makePoint(1,2);
  printf("Make point r: %d, %d!\n",r.x,r.y);
  HelloWorld();
  return 0;
}