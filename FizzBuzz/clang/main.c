#include <stdio.h>
#include <stdint.h>

void fizzbuzz(uint32_t start, uint32_t end)
{
  for (uint32_t number = start; number <= end; number++)
  {
    printf("%u", number);
    if (number % 15 == 0)
    {
      printf(":FizzBuzz");
    }
    else if (number % 3 == 0)
    {
      printf(":Fizz");
    }
    else if (number % 5 == 0)
    {
      printf(":Buzz");
    }
    else
    {
      ; // Do nothing
    }
    printf("\n");
  }
}

int main() {
  fizzbuzz(1, 100);
  return 0;
}
