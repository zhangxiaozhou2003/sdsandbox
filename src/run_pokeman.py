import subprocess
import argparse

def bringup(args):
    command_prefix = 'python predict_client.py --model={}'
    processes = []

    for _, value in args._get_kwargs():
        for arg in value:
            command = command_prefix.format(*[arg])
            process = subprocess.Popen(command,shell= True)
            processes.append(process)

if __name__ == "__main__":
    parser = argparse.ArgumentParser(description='prediction server')
    parser.add_argument('--models', nargs='+', help='model filenames as list')
    args = parser.parse_args()

    bringup(args)
