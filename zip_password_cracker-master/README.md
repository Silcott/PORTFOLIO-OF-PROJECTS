# Zip password cracker

[![Build Status](https://travis-ci.com/ebellocchia/zip_password_cracker.svg?branch=master)](https://travis-ci.com/ebellocchia/zip_password_cracker)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://raw.githubusercontent.com/ebellocchia/zip_password_cracker/master/LICENSE)

## Introduction

This is a small console application, written in C# using Visual Studio 2017, that I made for fun to play around with threads and threads synchronization.\
The application just tries to find the password of a Zip archive by brute-forcing all the possible combinations. To speed it up, multiple threads are used in order to try more combinations in parallel.\
Please note that, even with multiple threads, brute-forcing a password is still very time consuming, so do not expect to be able to crack long passwords (if the password is protected with AES-256 it'll be basically impossible because the trials are too slow).

**NOTE:** [DotNetZip](https://documentation.help/DotNetZip/About.htm) library is used internally for handling Zip archives.

## How it works

The way the application works is quite simple:
- One task is the password producer. It periodically produces a new password and enqueue it to the password queue. Since the producer is usually faster than the consumers, the maximum queue size is limited. If the queue is full, the producer will wait until some consumer dequeues a password.
- One or multiple tasks are the password consumers. They dequeue a password from the queue and try it on the Zip archive. If a task founds the correct password, it sets the result and all stop, otherwise it dequeues the next password.
- For logging to the console in a nice and clean way, without all the strings overlapping, the same logic is applied. So, password consumers enqueue their messages to a queue and a log consumer task dequeues and prints them to the console.

Everything is built by taking advantage of C# task library, so it's quite easy and clean.
Please note that the application is made for fun and experimenting, so it's not meant to be perfect or optimized.

## Building

Just open the Visual Studio solution and build the project in Debug or Release.\
The output folder is *VS2017_Project\ZipPasswordCracker\bin*.

## Usage

The application can be run as follows:

    ZipPasswordCracker.exe -f <ZIP_FILE_PATH> -l <LOG_FILE_PATH> [-n <THREADS_NUM> -i <INITIAL_PASSWORD>]

Arguments description:
- -f : path of the Zip archive
- -l : path of the log file where the output will be saved if password is found
- -n: number of threads to use (optional, default value: 1)
- -i: initial password to start with (optional, default value: empty string)

The maximum number of threads is limited to 20.\
Please note that a higher number of threads does not necessarily mean a faster execution. Above a certain number, you'll start getting worse performance. You can use to the elapsed time to check for it.\
For example, on my laptop (Intel i7-7700HQ), the best compromise is around 10 threads.

**Examples**

- Basic (1 thread, empty initial password):

        ZipPasswordCracker.exe -f C:\my_zip_file.zip -l log.txt

- Start application using 10 threads (empty initial password):

        ZipPasswordCracker.exe -f C:\my_zip_file.zip -l log.txt -n 10

- Start application using 10 threads and starting from password "01234":

        ZipPasswordCracker.exe -f C:\my_zip_file.zip -l log.txt -n 10 -i 01234

## License

This software is available under the MIT license.
