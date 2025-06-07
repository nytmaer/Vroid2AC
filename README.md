# VRoid2AC 🏎️✨

**Your Avatar. Your Ride. No Blender Required.**

Convert your VRoid avatars into Assetto Corsa driver models with zero technical knowledge. The first tool to bridge VTuber culture and sim racing.


## 🔥 Why VRoid2AC?

Ever wanted to race as your VTuber avatar? Tired of generic driver models in Assetto Corsa? **VRoid2AC is the missing link** between avatar creation and racing simulation.

- **🎭 VTuber Ready**: Import .VRM files directly from VRoid Studio
- **⚡ One-Click Pipeline**: No Blender, no 3D modeling skills needed
- **🏁 Racing Optimized**: Pre-configured for seated poses and steering wheel alignment
- **🎨 Style Preservation**: Maintains anime aesthetics with proper shader conversion
- **🔧 Modder Friendly**: Works with existing AC mods and Custom Shaders Patch
- **📺 Stream Perfect**: Stand out in replays and racing content

## 🚀 Quick Start

### For VTuber Creators
1. **Export** your avatar from VRoid Studio as .VRM
2. **Import** into VRoid2AC 
3. **Convert** with one click
4. **Race** as yourself in Assetto Corsa!

### For Sim Racers
1. **Download** any .VRM avatar from VRoid Hub
2. **Customize** with racing suits and helmets
3. **Export** to your AC driver folder
4. **Enjoy** personalized racing experience

## 🛠️ Installation

### Requirements
- **Unity 2022.3 LTS** or newer
- **UniVRM Package** (auto-installed)
- **Assetto Corsa** for testing
- **Custom Shaders Patch** (optional, for enhanced visuals)

### Setup
```bash
# Clone the repository
git clone https://github.com/nytmaer/VRoid2AC.git

# Open in Unity Hub
# Install UniVRM package via Package Manager
# Window → VRoid2AC → Main Window to start
```

## 🎯 Features

### ✅ Current (v1.0)
- VRM file import and analysis
- Basic material conversion (Standard → AC shaders)
- Unity Editor integration
- Preview system
- Export to AC format

### 🚧 In Development
- **Material Library**: Racing suits, helmets, and anime-style templates
- **CSP Shader Support**: Enhanced visuals for Custom Shaders Patch
- **Batch Processing**: Convert multiple avatars at once
- **Real-time Preview**: See your avatar in racing environment
- **Community Marketplace**: Share and download conversion templates

### 🎨 Planned Features
- **AI-Assisted Conversion**: Smart material detection and mapping
- **VTuber Agency Tools**: Bulk conversion for talent rosters
- **Racing Team Integration**: Custom liveries and sponsor logos
- **Multiplayer Sync**: See other players' avatars in online races
- **Streaming Integration**: OBS overlays with avatar branding

## 🎮 Supported Games

| Game | Status | Notes |
|------|--------|-------|
| **Assetto Corsa** | ✅ Full Support | Main target platform |
| **Assetto Corsa Competizione** | 🚧 Planned | Different file format |
| **BeamNG.drive** | 💭 Considering | Community requested |
| **rFactor 2** | 💭 Future | Similar to AC format |

## 🌟 Community

### For VTubers
- **Stand out** in racing content with your unique avatar
- **Easy setup** - no technical skills required
- **Stream-ready** with proper lighting and poses
- **Community templates** for popular racing series

### For Sim Racers  
- **Personalize** your driving experience
- **Create** custom driver skins
- **Share** conversions with the community
- **Support** your favorite VTuber creators

### For Modders
- **Extend** with custom shader templates
- **Build** community tools and integrations
- **Contribute** to the open-source ecosystem
- **Innovate** with new conversion techniques

## 🔧 Technical Details

### Shader Conversion Matrix
| VRoid Shader | AC Vanilla | AC + CSP | Features |
|--------------|------------|-----------|----------|
| MToon | ksPerPixel | smCarPaint | Toon → Realistic |
| Standard | ksPerPixelMultiMap | ksPerPixelMultiMap_NMDetail | Full PBR |
| Transparent | ksPerPixelMultiMap_AT | ksPerPixelMultiMap_AT | Alpha support |
| Emissive | ksPerPixelMultiMap_emissive | Enhanced emission | Glowing elements |

### File Format Support
- **Input**: .VRM (VRoid Studio, VRoid Hub, Booth)
- **Output**: .KN5 (Assetto Corsa native)
- **Textures**: DDS, PNG, JPG → DDS conversion
- **Materials**: Unity → AC material properties

## 📖 Documentation

- **[Setup Guide](Documentation/SETUP.md)** - Complete installation instructions
- **[User Manual](Documentation/USER_GUIDE.md)** - Step-by-step conversion process
- **[API Reference](Documentation/API.md)** - For developers and modders
- **[Shader Guide](Documentation/SHADERS.md)** - Understanding material conversion
- **[Troubleshooting](Documentation/TROUBLESHOOTING.md)** - Common issues and fixes

## 🤝 Contributing

We welcome contributions from both the VTuber and sim racing communities!

### Ways to Help
- **🐛 Bug Reports**: Found an issue? Let us know!
- **💡 Feature Requests**: What would make VRoid2AC better?
- **🎨 Template Creation**: Design racing suit templates
- **📝 Documentation**: Help others get started
- **💻 Code**: Improve the conversion pipeline

### Development Setup
```bash
# Fork the repository
# Clone your fork
# Create feature branch: git checkout -b feature/amazing-feature
# Make changes and test
# Submit pull request
```

See [CONTRIBUTING.md](Documentation/CONTRIBUTING.md) for detailed guidelines.

## 📊 Development Status

- **🎭 VRM Format** - Industry standard avatar format supported
- **🏎️ AC Integration** - Direct export to Assetto Corsa driver format
- **⚡ Unity-Based** - Robust foundation for cross-platform development
- **📺 Creator-Focused** - Built for streamers and content creators
- **🌍 Open Source** - MIT licensed for community growth

## 🚀 Roadmap

### 2025 Q2
- ✅ Basic VRM → AC conversion
- ✅ Unity Editor integration  
- ✅ Material library foundation

### 2025 Q3
- 🚧 Advanced shader support (CSP)
- 🚧 Community template marketplace
- 🚧 Batch processing tools

### 2025 Q4
- 📋 AI-assisted conversion
- 📋 VTuber agency partnerships
- 📋 Real racing brand collaborations

### 2026+
- 📋 Multi-game support (ACC, BeamNG)
- 📋 AR/VR integration
- 📋 Metaverse racing platforms

## 💬 Community & Support

Coming Soon!

## 📄 License

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE) file for details.

**TL;DR**: Use it for anything, modify it freely, share it widely. Just keep the license notice.

## 🙏 Acknowledgments

- **VRoid Studio Team** - For creating the amazing avatar creation platform
- **UniVRM Developers** - For the essential Unity VRM support
- **Assetto Corsa Modding Community** - For reverse-engineering the file formats
- **Custom Shaders Patch** - For extending AC's visual capabilities
- **VTuber Community** - For inspiring this project

## ⭐ Star History

[![Star History Chart](https://api.star-history.com/svg?repos=nytmaer/VRoid2AC&type=Date)](https://star-history.com/#nytmaer/VRoid2AC&Date)

---

**Made with ❤️ by the VRoid2AC Team**

*Bridging the gap between virtual personalities and racing passion, one avatar at a time.*

[⬆ Back to Top](#vroid2ac-️)
