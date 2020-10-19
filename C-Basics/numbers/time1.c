#include <stddef.h>
#include <time.h> 
#include <stdio.h> 
int main()
{
    time_t string_to_seconds(const char *timestamp_str)
    {
    struct tm tm;
    time_t seconds;
    int r;

    if (timestamp_str == NULL) {
        printf("null argument\n");
        return (time_t)-1;
    }
    r = sscanf(timestamp_str, "%d-%d-%d %d:%d:%d", &tm.tm_year, &tm.tm_mon, &tm.tm_mday, &tm.tm_hour, &tm.tm_min, &tm.tm_sec);
    if (r != 6) {
        printf("expected %d numbers scanned in %s\n", r, timestamp_str);
        return (time_t)-1;
    }

    tm.tm_year -= 1900;
    tm.tm_mon -= 1;
    tm.tm_isdst = 0;
    seconds = mktime(&tm);
    if (seconds == (time_t)-1) {
        printf("reading time from %s failed\n", timestamp_str);
    }

    return seconds;
}
}