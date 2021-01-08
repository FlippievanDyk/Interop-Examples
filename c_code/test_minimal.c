#include <stdio.h>


#define EXPORT __declspec(dllexport)
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

void HelloWorld () {
	printf("Hello world from gcc via f#\n");
}

int main() {
  printf() displays the string inside quotation
  printf("Hello, World version 2!\n");
  HelloWorld();
  return 0;
}