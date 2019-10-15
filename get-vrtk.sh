cd Assets
rm -rf VRTK
git clone --recurse-submodules https://github.com/ExtendRealityLtd/VRTK.git
cd VRTK
git submodule init && git submodule update