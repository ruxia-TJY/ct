#include<stdlib.h>
#include<stdio.h>
#include<string.h>

extern char **environ;

void path(char*Key);


int main(int argc,char *argv[])
{
	path((char*)"PATH");	
	return 0;
}

void path(char*Key)
{
	char*pathvar = getenv(Key);
	char *str;
	int len=0;
	str = (char*)malloc(sizeof(pathvar));
	
	str = strtok(pathvar,":");

	str = strtok(NULL,":");
	while(str){
		printf("%s\n",str);
		str=strtok(NULL,":");
		len += 1;
	}
	printf("-------------------------------------\n");
	printf("num is %d\n",len);
	free(str);
}

