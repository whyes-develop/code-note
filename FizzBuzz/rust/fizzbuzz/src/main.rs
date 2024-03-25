fn fizzbuzz(start: u32, end: u32)
{
  for number in start..=end
  {
    if number % 15 == 0
    {
      println!("{}:FizzBuzz", number);
    }
    else if number % 3 == 0
    {
      println!("{}:Fizz", number);
    }
    else if number % 5 == 0
    {
      println!("{}:Buzz", number);
    }
    else
    {
      println!("{}", number)
    }
  }
}

fn main()
{
  fizzbuzz(1, 100);
}
