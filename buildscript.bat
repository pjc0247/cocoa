cd {proj_dir}

android update project -p .

build_native.py

ant {build_type}