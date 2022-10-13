int friend = 2;
int first_friend_speed = 1;
int second_friend_speed = 2;
int dog_speed = 20;
int distance = 10000;
int count = 0;
int time = 0;

while (distance > 2)
{
    if (friend == 2)
    {
        time = distance / (dog_speed + second_friend_speed);
        friend = 1;
    }
    else
    {
        time = distance / (dog_speed + first_friend_speed);
        friend = 2;
    }
    distance = distance - (first_friend_speed - second_friend_speed) * time;
    count++;
}
Console.WriteLine(count);