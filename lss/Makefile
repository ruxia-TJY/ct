TARGET=lss
CC=gcc
Build=../bin/
Include=include

TARGET_PATH=$(Build)$(TARGET)

$(TARGET):main.c tColorPC.c
	$(CC) -o $(TARGET_PATH) -I$(Include) $^

.PHONY:clean
clean:
	-rm $(TARGET_PATH)

