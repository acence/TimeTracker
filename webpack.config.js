const path = require('path');

module.exports = (env) => {
    const prodMode = env && env.production == 'true';
    return {
        mode: prodMode ? 'production' : 'development',
        devtool: prodMode ? '(none)' : 'source-map',
        entry: {
            bundle: ['./Scripts/Main.jsx']
        },
        output: {
            path: path.resolve(__dirname, './wwwroot/js'),
            filename: '[name].js',
            publicPath: 'js/'
        },
        optimization: {
            splitChunks: {
                cacheGroups: {
                    commons: {
                        test: /[\\/]node_modules[\\/]/,
                        name: 'vendors',
                        chunks: 'all'
                    }
                }
            }
        },
        resolve: {
            extensions: ['*', '.js', '.jsx']
        },
        module: {
            rules: [
                {
                    test: /\.(js|jsx)/,
                    exclude: /node_modules/,
                    use: {
                        loader: 'babel-loader',
                        options: {
                            presets: ["@babel/preset-env", "@babel/preset-react"],
                            plugins: [["@babel/plugin-proposal-class-properties", { "loose": true }]]
                        }
                    }
                },
                {
                    test: /\.scss$/,
                    use: prodMode ? [
                        "css-loader",
                        "sass-loader"
                    ] : [
                        "style-loader",
                        "css-loader",
                        "sass-loader"
                    ]
                },
                {
                    test: /\.(woff(2)?|ttf|eot|svg)(\?v=\d+\.\d+\.\d+)?$/,
                    use: [
                        {
                            loader: 'file-loader',
                            options: {
                                name: '[name].[ext]',
                                outputPath: '../css/fonts/'
                            }
                        }
                    ]
                },
                {
                    test: /\.(png|jpg)(\?v=\d+\.\d+\.\d+)?$/,
                    use: [
                        {
                            loader: 'file-loader',
                            options: {
                                name: '[name].[ext]',
                                outputPath: '../css/images/'
                            }
                        }
                    ]
                }
            ]
        }
    }
};