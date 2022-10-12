module.exports = {
    aliases: {
        "@node_modules": "./node_modules",
        "@libs": "./wwwroot/libs"
    },
    clean: [
        "@libs"
    ],
    mappings: {
        "@node_modules/requirejs/require.js": "@libs/requirejs/",

        "@node_modules/monaco-editor/min/vs/": "@libs/monaco-editor/min/vs/",
    }
};
