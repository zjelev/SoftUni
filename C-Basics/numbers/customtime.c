#include <stdio.h>
#include <time.h>
#include <unistd.h>

int main(void)
{
    int tmpyear, tmpmon;
    time_t     then;
    struct tm  cts;
        time(&then);
        cts=*localtime(&then);
        printf("\nCheck timestamp of a date: \n");
        printf("Input year > 1900: ");
        scanf("%i", &tmpyear);
        //printf("year is %i \n", tmpyear);
        cts.tm_year=tmpyear-1900;
        printf("Input month > 1: ");
        scanf("%i", &tmpmon);
        cts.tm_mon=tmpmon-1;
        printf("Input date >1 <31: ");
        scanf("%i", &cts.tm_mday);
        /*printf("Input hour: ");
        scanf("%i", &cts.tm_hour);
        printf("Input min: ");
        scanf("%i", &cts.tm_min);
        printf("Input sec: ");
        scanf("%i", &cts.tm_sec);*/
        printf("Input time and date: %s \n", asctime(&cts));
        printf("Timestamp is %d", cts);
        return 0;
}