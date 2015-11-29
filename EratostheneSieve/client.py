import clr
import os
clr.AddReferenceToFileAndPath(
    os.path.join(os.path.dirname(__file__), r"bin\Debug\EratostheneSieve.dll")
)
import EratostheneSieve


if __name__ == '__main__':
    for ceil in (0, 1, 2, 3, 7, 13, 28):
        print("Computing sieve for {}: {}".format(
            ceil,
            [i for i in EratostheneSieve.Sieve.Compute(ceil)]
        ))