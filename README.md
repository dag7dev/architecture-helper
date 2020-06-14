# Hit/Miss Cache calculator

A simple python3 hit or miss cache calculator, created to test a list of memory access in an hardware cache.

## Getting Started

To get this program clone it with git via:

```
git clone https://github.com/dag7dev/hit-miss-cache-calc.git
```

Otherwise if you're not familiar with git you can download it as a zip from
[Here](https://github.com/dag7dev/hit-miss-cache-calc/archive/master.zip).


### Prerequisites

To run this program you need Python, wich you can install from
[Here](https://www.python.org/downloads/).

This program was written for Python 3.8.3, but *hopefully* it should be compatible with future versions of Python too as it uses really few imports.


### Running

To run the program simply run:
```
main.py
```

### Parameters

You can look at the available parameters by running:
```
main.py -h
```

The output should be something like this:
```
Usage: 
        no parameters: 
                interactive mode - write your own data
        -t: 
                test mode - work with an example - no other parameter needed
        -f filename: 
                file mode - import data from a json file - you shall pass the filename
        -h: 
                help mode - you are reading this!
```

**NOTE:** Keep in mind that the [README](./README.md) could be not always updated with the latest parameters, so always refer to the output of `main.py -h` rather that what's written here.


## Contributing

If you want to request for a functionality to be implemented or you found a bug you can open an [Issue](https://github.com/dag7dev/hit-miss-cache-calc/issues)

If you have a fix/improvement for something you can Fork the project and submit a Pull Request.

Also if you want to be a contributor contact [dag7dev](https://github.com/dag7dev)

## Authors

* **Damiano** - *Initial work on the 2-way cache simulator and data input* - [dag7dev](https://github.com/dag7dev)
* **Fede Capece** - *Revised n-way cache simulator and user input* - [fc-dev](https://github.com/fc-dev)

See also the list of [contributors](https://github.com/dag7dev/hit-miss-cache-calc/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
