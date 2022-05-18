rm -r ../ImversedLibrary/*.cs

mkdir -p ../ImversedLibrary


proto_dirs=$(find ./ -path -prune -o -name '*.proto' -print0 | xargs -0 -n1 dirname | sort | uniq)

for dir in $proto_dirs; do
  tmp=$(echo $dir| cut -b 3-)
  path="../ImversedLibrary/${tmp}"
  mkdir -p $path
  protoc \
   -I/usr/local/include -I ./ \
   --csharp_out=$path \
   --grpc_out=$path \
   --plugin=protoc-gen-grpc=grpc-protoc_macos_x64-1.46.0-dev/grpc_csharp_plugin \
    $(find "${dir}" -maxdepth 1 -name '*.proto')

done
