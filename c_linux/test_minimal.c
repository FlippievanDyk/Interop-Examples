#include <stdio.h>


int one () {
  return 1;
}

int two () {
	return 2;
}

int addOne (int i) {
	return i + 1;
}

int addTwo (int i) {
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