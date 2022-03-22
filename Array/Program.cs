byte[] array = new byte[9];

for (int i = 0; i < 9; i++)
{
    array[i] = (byte)(i + 1);
}

for (int i = 0; i < array.Length; i++)
{
    if (i == 5)
    {
        array[i] *= 2;
    }
}