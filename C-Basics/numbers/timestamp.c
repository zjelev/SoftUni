#include <stdio.h>
#include <time.h>
#include <unistd.h>

int main(void)
{
    time_t     now, now1, now2;
    struct tm  ts, cts;
    char       buf[80], buf1[80];
        // Get current time
        //int year_pr, unixts;
        //time(&now);
        /*ts = *localtime(&now);
        strftime(buf, sizeof(buf), "%a %Y-%m-%d %H:%M:%S", &ts);
        //year_pr = ts.tm_year;
        printf("Local Time %s\n", buf);*/
        printf("Local Timestamp %i\n", time(&now));
        //UTC time
        now2 = now - 19800;  //from local time to UTC time
        ts = *localtime(&now2);
        strftime(buf, sizeof(buf), "%a %Y-%m-%d %H:%M:%S", &ts);
        printf("UTC time %s\n", buf);
        //TAI time valid upto next Leap second added
        now1 = now + 37;    //from local time to TAI time
        ts = *localtime(&now1);
        strftime(buf, sizeof(buf), "%a %Y-%m-%d %H:%M:%S", &ts);
        printf("TAI time %s\n", buf);
        return 0;
}