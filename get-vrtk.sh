cd Assets
rm -rf VRTK
git clone --recurse-submodules https://github.com/ExtendRealityLtd/VRTK.git
cd VRTK
git reset --hard 29d098ce511e9c18a189327b74029b193d6011a9
git submodule init && git submodule update