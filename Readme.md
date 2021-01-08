# Interop .Net Testing

## Notes

The dotnet compilers that I am working with are 64 bit. This caused a few quirks when trying to add 32bit dll files.

This may or may not be an issue when using this in practice. It might be better for the interop programs sake, to make use of a 32bit runtime.

## OS specific

---

### Windows

Compiling test.c with ```clang .\test.c -o a.out``` works.
Compiling with gcc does not work. Looking for work around.

GCC, it turns out doesn't work due too being 32bit. I used the -m54 flag to set it to 64bit, and got the error ```cc1.exe: sorry, unimplemented: 64-bit mode not compiled in```
Thankfully clang is 64bit by default, which fixes that issue in windows.

Windows requires the ugly addition of ```__declspec(dllexport)``` to each function to be used with interop.

### Linux

Linux working with command ```gcc -m64 -shared -o a.out test.c```.
Linux working with command ```clang -shared -o a.out test.c```.

Linux does not require the the use of ```__declspec(dllexport)``.

### OSX

Don't have access to mac, but should be similar to Linux.

---

## Thoughts

This can work well. Any build server would use linux to run the tests.

Since the F# code would be produced first, any interop-based tests would no the under active development. So using it as a build server and then just running tests is very possible.
