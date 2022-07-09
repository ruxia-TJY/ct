# run in linux

# create ./bin folder
if [ ! -d bin  ];then
  mkdir bin
fi

# cd and make
cd p && make
cd ../
cd lss && make
cd ../



# clean
if [ $# -gt 0 ];then
  if [ $1 = clean ];then
    rm */*.o
    rm -rf bin
  fi
fi
